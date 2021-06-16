using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centrala
{
    public class ArchiveBuffer
    {
        private int BufferSize = 100;
        private bool IsTimeBuffer = false;

        private object locker = new object();

        public List<double> Buffer = new List<double>();
        public List<DateTime> DateBuffer = new List<DateTime>();

        public ArchiveBuffer(bool isTime = false)
        {
            if (isTime)
                IsTimeBuffer = true;
        }

        public void EnterValue(double val)
        {
            if (Buffer.Count >= BufferSize)
                Buffer.RemoveAt(0);
            Buffer.Add(val);
        }

        public void EnterValue(DateTime time)
        {
            if (DateBuffer.Count >= BufferSize)
                DateBuffer.RemoveAt(0);
            DateBuffer.Add(time);
        }

        public void ClearBuffer()
        {
            if(IsTimeBuffer)
                DateBuffer.Clear();
            else
                Buffer.Clear();
        }

    }
}
