using System;
using System.Net.NetworkInformation;
using System.Text;

namespace CIS_Lab4
{
    /// <summary>
    /// Mac address generator.
    /// <remarks>This object is static.</remarks>
    /// </summary>
    static class MacGenerator
    {
        private static readonly Random Random = new Random();

        /// <summary>
        /// Represents <see cref="Int32"/> value with lower random generator treshold.
        /// </summary>
        private const int LowerOctetTreshold = 8;

        /// <summary>
        /// Represents <see cref="Int32"/> value with upper random generator treshold.
        /// </summary>
        private const int UpperOctetTreshold = 256;

        /// <summary>
        /// Generates full random mac address.
        /// </summary>
        /// <returns>Returns <see cref="PhysicalAddress"/> object with generated value.></returns>
        public static PhysicalAddress GenerateAddress() {
            
            var stringAddress = GenerateOctet();
            int addressOctet;

            // Generating last 5 octets excepting first
            for (var i = 0; i < 5; i++)
            {
                addressOctet = Random.Next(UpperOctetTreshold);
                stringAddress += $"-{addressOctet:X2}";
            }

            return PhysicalAddress.Parse(stringAddress);
        }

        /// <summary>
        /// Generates first octet of mac address represented by string value.
        /// </summary>
        /// <param name="mask">Mac address mask for generating target.</param>
        /// <returns>Returns <see cref="string"/> value with mask for mac address with first generated octet.</returns>
        public static string GenerateFirstOctetInMask(string mask)
        {
            var finalResult = new StringBuilder(mask);
            finalResult.Remove(0, 2);
            finalResult.Insert(0, GenerateOctet());

            return finalResult.ToString();
        }

        static string GenerateOctet()
        {
            // Setting address octet range.
            var addressOctet = Random.Next(LowerOctetTreshold, UpperOctetTreshold);

            /*
             * Here we taking string representation,
             * converting octet to binary and setting it to global.
             */
            var stringOctet = Convert.ToString(addressOctet, toBase:2);
            stringOctet = stringOctet.Remove(stringOctet.Length-2, 2);
            stringOctet = stringOctet.Insert(stringOctet.Length, "00");

            // Convreting string octet value to Int32
            addressOctet = Convert.ToInt32(stringOctet, fromBase:2);

            // Filling address string
            var stringAddress = string.Empty;
            stringAddress += addressOctet.ToString("X2");
            return stringAddress;
        }
    }
}
