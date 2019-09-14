using System;
using System.IO;
using System.Text;

namespace AlgorthimsClass1
{
    class Program
    {
        public static GuidDataGenerator guidDataGenerator;

        static void Main(string[] args)
        {
            guidDataGenerator = new GuidDataGenerator();
            guidDataGenerator.AddValueToCSV();
        }

    }
}
