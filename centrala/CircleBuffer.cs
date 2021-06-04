using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filtry
{
    public class CircleBuffer
    {
        // rozmiar bufora
        private int bufferSize;
        // aktualna pozycja bufora
        public int currentPosition { get; set; } = 0;
        // lista z elementami bufora
        private List<double> buffer;

        /// <summary>
        /// Inicjalizuje bufor
        /// </summary>
        /// <param name="size">Rozmiar bufora</param>
        public CircleBuffer(int size)
        {
            bufferSize = size;
            buffer = new List<double>(new double[bufferSize]);
        }

        /// <summary>
        /// Funkcja wpisująca nową wartość do bufora kołowego
        /// </summary>
        /// <param name="value">Wartość która ma być wpisana do bufora</param>
        public void enterValue(double value)
        {
            // wpisywanie wartości do bufora
            buffer[currentPosition] = value;

            // aktualizacja aktualnej pozycji
            currentPosition++;
            currentPosition %= bufferSize;
        }

        /// <summary>
        /// Funkcja odczytująca wartość z bufora kołowego, z podanym przesunięciem
        /// </summary>
        /// <param name="index">Przesunięcie względem indeksu startowego</param>
        /// <returns></returns>
        public double getValue(int index)
        {
            int tempIndex = currentPosition - 1 - index;
            int indexNormalized = tempIndex >= 0 ? tempIndex : bufferSize + tempIndex;
            double temp = buffer[indexNormalized];
            return temp;
        }
    }
}
