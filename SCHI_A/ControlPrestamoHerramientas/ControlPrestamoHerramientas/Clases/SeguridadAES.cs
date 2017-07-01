﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
//using System.Security.Cryptography;

namespace ControlPrestamoHerramientas.Clases
{
    public static class SeguridadAES
    {
        public static byte[] clave;
        public static byte[] iv;
        public static string input = "12EstaClave34es56dificil489ssswf";
        public static string input2 = "12EstaClave1trlo";

 

        public static string Encriptar(string inputText)
        {
            
             clave = Encoding.UTF8.GetBytes("12EstaClave34es56dificil489ssswf");
            iv=Encoding.UTF8.GetBytes("Devjoker7.37hAES"); 
            
            byte[] inputBytes = Encoding.ASCII.GetBytes(inputText);

            byte[] encripted;

            RijndaelManaged cripto = new RijndaelManaged();

            using (MemoryStream ms =

                new MemoryStream(inputBytes.Length))
            {

                using (CryptoStream objCryptoStream =

                    new CryptoStream(ms,

                           cripto.CreateEncryptor(clave, iv),

                           CryptoStreamMode.Write))
                {

                    objCryptoStream.Write(inputBytes, 0, inputBytes.Length);

                    objCryptoStream.FlushFinalBlock();

                    objCryptoStream.Close();

                }

                encripted = ms.ToArray();
                
            }

            return Convert.ToBase64String(encripted);

        }

        public static string Desencriptar(string inputText)
        {

            byte[] inputBytes = Convert.FromBase64String(inputText);

            byte[] resultBytes = new byte[inputBytes.Length];

            string textoLimpio = String.Empty;

            RijndaelManaged cripto = new RijndaelManaged();

            using (MemoryStream ms = new MemoryStream(inputBytes))
            {

                using (CryptoStream objCryptoStream =

                new CryptoStream(ms, cripto.CreateDecryptor(clave, iv),

                        CryptoStreamMode.Read))
                {

                    using (StreamReader sr =

                        new StreamReader(objCryptoStream, true))
                    {

                        textoLimpio = sr.ReadToEnd();

                    }

                }

            }

            return textoLimpio;

        }

        public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        public static string EncryptText(string password)
        {
            //string input = "12EstaClave34es56dificil489ssswf";
            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input2);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            
            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);
            //input2 = result;
            return result;
            
        }

        public static string DecryptText(string password)
        {
            
            // Get the bytes of the string
            byte[] bytesToBeDecrypted = Convert.FromBase64String(input2);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            string result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }







    }
}
