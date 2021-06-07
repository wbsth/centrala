using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centrala
{
    public class ArchiveBuffer
    {
        private static int BufferSize = 100;
        public List<double> Buffer = new List<double>();

        public void EnterValue(double val)
        {
            if (Buffer.Count >= BufferSize)
                Buffer.RemoveAt(0);
            Buffer.Add(val);
        }

        public void ClearBuffer()
        {
            Buffer.Clear();
        }

    }
}
