namespace R3BinderTools.GenTools
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    public static class GenString
    {
        public static string RandomString(int length)
        {
            const string ALPHABET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            var res = new StringBuilder(length);
            try
            {
                using var rng = new RNGCryptoServiceProvider();
                while (res.Length < length)
                {
                    int count = (int)Math.Ceiling(Math.Log(ALPHABET.Length, 2) / 8.0);
                    int offset = BitConverter.IsLittleEndian ? 0 : sizeof(uint) - count;
                    byte[] uintBuffer = new byte[sizeof(uint)];
                    rng.GetBytes(uintBuffer, offset, count);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    if (num < (int)(Math.Pow(2, count * 8) / ALPHABET.Length) * ALPHABET.Length)
                    {
                        res.Append(ALPHABET[(int)(num % ALPHABET.Length)]);
                    }
                }
            }
            catch { }

            return res?.ToString();
        }

        public static string Inizialize(int buffer)
        {
            string result = string.Empty;
            try
            {
                using var rnd = new RNGCryptoServiceProvider();
                var buf = new byte[buffer];
                rnd?.GetBytes(buf);
                result = Convert.ToBase64String(buf);
            }
            catch { }
            return result;
        }

        public static string GeneratePasswordResetToken()
        {
            string result = string.Empty;
            try
            {
                string token = Guid.NewGuid().ToString();
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(token);
                result = Convert.ToBase64String(plainTextBytes);
            }
            catch { }
            return result;
        }
    }
}