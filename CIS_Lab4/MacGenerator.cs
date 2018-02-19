﻿using System;
using System.Net.NetworkInformation;
using System.Text;

namespace CIS_Lab4
{
    static class MacGenerator
    {
        private static readonly Random Random = new Random();

        public static PhysicalAddress GenerateAddress() {

            const int lowerOctetTreshold = 8;
            const int upperOctetTreshold = 256;

            var addressOctet = Random.Next(lowerOctetTreshold, upperOctetTreshold);

            var stringOctet = Convert.ToString(addressOctet, toBase:2);
            stringOctet = stringOctet.Remove(stringOctet.Length-2, 2);
            stringOctet = stringOctet.Insert(stringOctet.Length, "00");

            addressOctet = Convert.ToInt32(stringOctet, fromBase:2);

            var stringAddress = string.Empty;
            stringAddress += addressOctet.ToString("X2");

            for (var i = 0; i < 5; i++)
            {
                addressOctet = Random.Next(upperOctetTreshold);
                stringAddress += $"-{addressOctet:X2}";
            }

            return PhysicalAddress.Parse(stringAddress);
        }

        public static string GenerateFirstOctet(string mask)
        {
            int octet;
            string stringOctet;
            var finalResult = new StringBuilder(mask);

            octet = Random.Next(8, 256);
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
