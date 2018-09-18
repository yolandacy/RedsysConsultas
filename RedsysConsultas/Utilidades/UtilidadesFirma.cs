using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RedsysConsultas.Utilidades
{
    public class UtilidadesFirma
    {
        public static string EncodeTo64(string cadena)
        {
            byte[] toEncodeAsBytes = Encoding.GetEncoding(1252).GetBytes(cadena);
            return Convert.ToBase64String(toEncodeAsBytes);
        }

        public static string DecodeFrom64(string cadena)
        {
            byte[] binary = Convert.FromBase64String(cadena);
            return Encoding.GetEncoding(1252).GetString(binary);
        }

        public static byte[] HashHMAC(string cadena, string key)
        {
            key = key ?? "";
            var encoding = Encoding.GetEncoding(1252);
            byte[] keyByte = encoding.GetBytes(key);
            byte[] messageBytes = encoding.GetBytes(cadena);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return hashmessage;
            }
        }

        public static string EncryptTripleDES(string textKey, string content)
        {
            byte[] key = Encoding.GetEncoding(1252).GetBytes(textKey);
            byte[] iv = new byte[8];
            byte[] data = Encoding.GetEncoding(1252).GetBytes(content);
            byte[] enc = new byte[0];
            System.Security.Cryptography.TripleDES tdes = System.Security.Cryptography.TripleDES.Create();
            tdes.IV = iv;
            tdes.Key = key;
            tdes.Mode = CipherMode.CBC;
            tdes.Padding = PaddingMode.Zeros;
            ICryptoTransform ict = tdes.CreateEncryptor();
            enc = ict.TransformFinalBlock(data, 0, data.Length);
            return Encoding.GetEncoding(1252).GetString(enc);
        }

    }
}
