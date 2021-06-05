using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centrala
{
    public class CircleBuffer
    {
        // rozmiar bufora
        private int bufferSize;
        // aktualna pozycja bufora
        public int CurrentWritePosition { get; set; } = 0;
        public int CurrentReadPosition { get; set; } = 0;
        // lista z elementami bufora
        private List<byte> buffer;

        /// <summary>
        /// Inicjalizuje bufor
        /// </summary>
        /// <param name="size">Rozmiar bufora</param>
        public CircleBuffer(int size)
        {
            bufferSize = size;
            buffer = new List<byte>(new byte[bufferSize]);
        }

        /// <summary>
        /// Funkcja wpisująca nową wartość do bufora kołowego
        /// </summary>
        /// <param name="value">Wartość która ma być wpisana do bufora</param>
        public void EnterValue(byte value)
        {
            // wpisywanie wartości do bufora
            buffer[CurrentWritePosition] = value;

            // aktualizacja aktualnej pozycji
            CurrentWritePosition++;
            CurrentWritePosition %= bufferSize;
        }

        /// <summary>
        /// Funkcja odczytująca wartość z bufora kołowego
        /// </summary>
        public byte GetValue()
        {
            if (CurrentReadPosition == CurrentWritePosition)
                return (byte)'#';

            byte tempReturn = buffer[CurrentReadPosition];
            CurrentReadPosition++;
            CurrentReadPosition %= bufferSize;
            return tempReturn;
        }
    }
}
