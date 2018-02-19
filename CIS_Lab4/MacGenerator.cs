using System;
using System.Net.NetworkInformation;
using System.Text;

namespace CIS_Lab4
{
    class MacGenerator
    {
        public static Random rnd = new Random();
        public static PhysicalAddress GenerateAddress()
        {
            int octet;
            string stringOctet;
            PhysicalAddress address;
            string stringAddress = "";

            octet = rnd.Next(8,256);
            stringOctet = Convert.ToString(octet, 2);
            stringOctet = stringOctet.Remove(stringOctet.Length-2, 2);
            stringOctet.Insert(stringOctet.Length, "00");
            octet = Convert.ToInt32(stringOctet,2);
            stringAddress += octet.ToString("X2");

            for (int i = 0; i < 5; i++)
            {
                octet = rnd.Next(256);
                stringAddress += "-" + octet.ToString("X2");
            }

            address = PhysicalAddress.Parse(stringAddress);
            //MessageBox.Show(stringAddress);
            return address;
        }

        public static string GenerateFirstOctet(string mask)
        {
            int octet;
            string stringOctet;
            var finalResult = new StringBuilder(mask);

            octet = rnd.Next(8, 256);
            stringOctet = Convert.ToString(octet, 2);
            stringOctet = stringOctet.Remove(stringOctet.Length - 2, 2);
            stringOctet.Insert(stringOctet.Length, "00");
            octet = Convert.ToInt32(stringOctet, 2);

            finalResult.Remove(0, 2);
            finalResult.Insert(0, octet.ToString("X2"));

            return finalResult.ToString();
        }
    }
}
