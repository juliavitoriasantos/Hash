using System;
using System.Security.Cryptography;
using System.Text;

namespace Login_Hash
{
    public static class Crypto
    {
        // Método para criptografar usando MD5
        public static string md5encrypt(string frase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            MD5CryptoServiceProvider md5hasher = new MD5CryptoServiceProvider();
            byte[] hashedDataBytes = md5hasher.ComputeHash(encoder.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }

        // Método para criptografar usando SHA1
        public static string sha1encrypt(string frase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA1CryptoServiceProvider sha1hasher = new SHA1CryptoServiceProvider();
            byte[] hashedDataBytes = sha1hasher.ComputeHash(encoder.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }

        // Método para criptografar usando SHA256
        public static string sha256encrypt(string frase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }

        // Método para criptografar usando SHA384
        public static string sha384encrypt(string frase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA384Managed sha384hasher = new SHA384Managed();
            byte[] hashedDataBytes = sha384hasher.ComputeHash(encoder.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }

        // Método para criptografar usando SHA512
        public static string sha512encrypt(string frase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA512Managed sha512hasher = new SHA512Managed();
            byte[] hashedDataBytes = sha512hasher.ComputeHash(encoder.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }

        // Converte o array de bytes para uma string hexadecimal
        private static string byteArrayToString(byte[] inputArray)
        {
            StringBuilder output = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++)
            {
                output.Append(inputArray[i].ToString("X2"));
            }
            return output.ToString();
        }
    }
}