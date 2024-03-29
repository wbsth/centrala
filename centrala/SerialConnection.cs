﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace centrala
{
    public class SerialConnection : INotifyPropertyChanged
    {
        SerialPort port;
        AirData airData;
        Logs logs;
        CircleBuffer buffer;
        
        public DateTime lastMessageTime;

        List<byte> tempBytes = new List<byte>();
        private readonly MainForm form;
        List<byte> tempByteList;
        bool insideMessage;

        public bool PortOpen { get; set; }

        private object locker = new object();

        // domyślne ustawienia
        private string _ComPort = "COM3";
        public string ComPort
        {
            get
            {
                return _ComPort;
            }
            set {
                if (Equals(value, _ComPort)) return;
                _ComPort = value;
                OnPropertyChanged();
            }
        }
        public int BaudRate { get; set; } = 9600;
        public int DataBits { get; set; } = 8;
        public Parity ParitySetting { get; set; } = Parity.None;
        public StopBits StopBits { get; set; } = StopBits.One;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public SerialConnection(MainForm mainForm, AirData airData, Logs logs)
        {
            form = mainForm;
            this.airData = airData;
            this.logs = logs;
            buffer = new CircleBuffer(2048);
            tempByteList = new List<byte>();
            insideMessage = false;
        }

        public bool CreateConnection()
        {
            if(port != null)
            {
                CloseConnection();
            }
            port = new SerialPort(_ComPort, BaudRate, ParitySetting, DataBits, StopBits);
            port.DataReceived += Port_DataReceived;
            port.Open();
            if (port.IsOpen)
            {
                form.changeStatusIndicator(true);
                PortOpen = true;
                return true;
            }
            return false;            
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] buff = new byte[port.BytesToRead];
                int rcvdBytes = port.Read(buff, 0, buff.Length);
                lock (locker)
                {
                    foreach(byte item in buff)
                    {
                        buffer.EnterValue(item);
                    }
                }
                ThreadPool.QueueUserWorkItem(handleReceivedBytes);
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            //form.changeDataIndicator(true);
            //while(port.BytesToRead > 0)
            //{
            //    buffer.EnterValue((byte)port.ReadByte());
            //    //tempBytes.Add((byte)port.ReadByte());
            //}
            //ProcessBuffor();
            //await Task.Delay(TimeSpan.FromMilliseconds(25));
            //form.changeDataIndicator(false);
        }

        private void handleReceivedBytes(object state)
        {
            lastMessageTime = DateTime.Now;
            ProcessBuffor();
        }

        public void CloseConnection()
        {
            port.Close();
            port.Dispose();
            PortOpen = false;
            form.changeStatusIndicator(false);
        }

        private void ProcessBuffor()
        {
            //Console.WriteLine($"Read:{buffer.CurrentReadPosition}, Write:{buffer.CurrentWritePosition}");
            byte temp;

            while (true)
            {
                temp = buffer.GetValue();
                if (temp == '#')
                {
                    //Console.WriteLine("# encountered");
                    break;
                }
                if (temp == '$')
                {
                    //Console.WriteLine("$ encountered");
                    insideMessage = true;
                }
                else if (insideMessage)
                {
                    if (temp == '\n')
                    {
                        //Console.WriteLine("end of message");
                        MessageParser(Encoding.ASCII.GetString(tempByteList.ToArray()));
                        insideMessage = false;
                        tempByteList.Clear();
                    }
                    else
                    {
                        tempByteList.Add(temp);
                        //Console.WriteLine(tempByteList.Count);
                    }
                }
            }
        }

        /// <summary>
        /// Parse message received from air data computer and update AirData with this new values
        /// </summary>
        /// <param name="message">message to be parsed</param>
        private void MessageParser(string message)
        {
            string[] splittedValues = message.Split(',');
            if(splittedValues.Length == 5)
            {
                //Console.WriteLine("Parsuje wiadomosc");
                airData.TimeBuffer.EnterValue(DateTime.Now);
                airData.SpeedIAS = Helpers.ParseDoubleString(splittedValues[0]);
                airData.Altitude = Helpers.ParseDoubleString(splittedValues[1]);
                airData.SpeedVertical = Helpers.ParseDoubleString(splittedValues[2]);
                airData.Temperature = Helpers.ParseDoubleString(splittedValues[3]);
                airData.SpeedTAS = Helpers.ParseDoubleString(splittedValues[4]);
                logs.MyTimer_Tick();
            }

        }
    }
}
