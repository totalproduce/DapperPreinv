using System;
using System.Text;

namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.DatabaseConnection
{

    /// <summary>
    /// Handle simple encyption and decryption for passwords stored in a file
    /// </summary>
    public static class Encryption
    {
        /// <summary>
        /// Encrypt some text
        /// </summary>
        /// <param name="source">The text to encrypt</param>
        /// <returns>The encrypted text</returns>
        public static string Encrypt(string source)
        {
            var encrypted = string.Empty;

            for (int i = source.Length - 1; i >= 0; i--)
            {
                var sourceChar = source[i];

                byte[] asciiCodesArray = Encoding.ASCII.GetBytes(new char[] { sourceChar });

                byte[] paddedBytes = new byte[4] { asciiCodesArray[0], 0x00, 0x00, 0x00 };

                int asciiVal = BitConverter.ToInt32(paddedBytes, 0);
                asciiVal += i + 1;

                byte[] encryptedBytes = BitConverter.GetBytes(asciiVal);

                var encryptedChar = Encoding.ASCII.GetChars(encryptedBytes);

                encrypted += encryptedChar[0];
            }

            return encrypted;
        }

        public static string Decrypt(string source)
        {
            var decrypted = string.Empty;

            int j = 0;
            for (int i = source.Length - 1; i >= 0; i--)
            {
                ++j;

                var sourceChar = source[i];

                byte[] asciiCodesArray = Encoding.ASCII.GetBytes(new char[] { sourceChar });

                byte[] paddedBytes = new byte[4] { asciiCodesArray[0], 0x00, 0x00, 0x00 };

                int asciiVal = BitConverter.ToInt32(paddedBytes, 0);
                asciiVal -= j;

                byte[] encryptedBytes = BitConverter.GetBytes(asciiVal);

                var encryptedChar = Encoding.ASCII.GetChars(encryptedBytes);

                decrypted += encryptedChar[0];
            }

            return decrypted;
        }
    }
}
