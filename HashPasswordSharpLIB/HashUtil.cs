using System;
using System.Security.Cryptography;
using System.Text;

namespace de.janbusch.HashPasswordSharp.lib
{
    /// <summary>
    /// This utility class contains static methods for generating passwords from passphrases using different hashing algorithms.
    /// </summary>
    /// <remarks>Algorithm: Juergen Busch</remarks>
    public static class HashUtil
    {
        /// <summary>
        /// Enumeration defines all supported hashalgorithms in HashPasswordSharp.
        /// </summary>
        public enum SupportedHashAlgorithm { MD5, SHA1, SHA256, SHA384, SHA512 }

        /// <summary>
        /// Method for generating password from the input values.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="login"></param>
        /// <param name="passphrase"></param>
        /// <param name="algorithm"></param>
        /// <param name="characterSet"></param>
        /// <param name="maxPwLength"></param>
        /// <returns>Generated password</returns>
        public static string GeneratePassword(string host, string login,
            string passphrase, SupportedHashAlgorithm algorithm, string characterSet,
            int maxPwLength)
        {
            var hashAlgorithm = CryptoConfig.CreateFromName(algorithm.ToString()) as HashAlgorithm;

            string basestring;
            if (login.Length == 0)
            {
                basestring = passphrase + "@" + host;
            }
            else
            {
                basestring = login + "@" + host + "#" + passphrase;
            }
            byte[] digest = CreateHash(hashAlgorithm, basestring);

            int digestLength = digest.Length;
            string sPassword = "";

            int pos = 0;
            int bitno = 0;
            int charSetLength = characterSet.Length;

            int maxBitCnt = (int)Math.Ceiling(Math.Log(charSetLength) / Math.Log(2));

            for (int i = 0; (i < maxPwLength)
                    && ((pos * 8 + bitno) < (digestLength * 8)); ++i)
            {
                int part = 0;
                int bitCnt = maxBitCnt;
                int actPos = pos;
                int actBitno = bitno;

                int j = 0;

                for (; (j < bitCnt)
                        && ((actPos * 8 + actBitno) < (digestLength * 8)); ++j)
                {
                    part <<= 1;
                    part |= ((digest[actPos] & (1 << actBitno)) != 0) ? 1 : 0;
                    if (++actBitno >= 8)
                    {
                        ++actPos;
                        actBitno = 0;
                    }
                }

                if (part >= charSetLength)
                {
                    part >>= 1;
                    --actBitno;
                    if (actBitno < 0)
                    {
                        --actPos;
                        actBitno = 7;
                    }
                }

                bitno = actBitno;
                pos = actPos;

                sPassword = sPassword + characterSet[part];
            }

            return sPassword;
        }

        /// <summary>
        /// This method creates a hash of the given string using the given hashalgorithm.
        /// </summary>
        /// <param name="hashAlgorithm"></param>
        /// <param name="basestring"></param>
        /// <returns>Hash from basestring</returns>
        private static byte[] CreateHash(HashAlgorithm hashAlgorithm, string basestring)
        {
            // byte array representation of that string
            byte[] encodedPassword = new UTF8Encoding().GetBytes(basestring);

            // need MD5 to calculate the hash
            byte[] hash = hashAlgorithm.ComputeHash(encodedPassword);

            return hash;
        }
    }
}
