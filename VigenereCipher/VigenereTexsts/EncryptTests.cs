using System;
using VigenereCipher;
using Xunit;

namespace VigenereTexsts
{
    public class EncryptTests
    {
        [Fact]
        public void TestCheckFalse()
        {
            Encryption encryption = new Encryption();
            var check = encryption.Encrypt("he‚Ù˚lo", "kk",out string Cipher);
            Assert.False(check);
        }

        [Fact]
        public void TestCheckTrueBig()
        {
            Encryption encryption = new Encryption();
            var check = encryption.Encrypt("Hello", "kk", out string Cipher);
            Assert.True(check);
        }
        [Fact]
        public void TestCheckTrueSmall()
        {
            Encryption encryption = new Encryption();
            var check = encryption.Encrypt("hello", "kkdada", out string Cipher);
            Assert.True(check);
        }

        [Fact]
        public void —heckKeyFalse1()
        {
            Encryption encryption = new Encryption();
            var check = encryption.Encrypt("hello", "‚˚‚Ù˚‚Ù˚", out string Cipher);
            Assert.False(check);
        }
        [Fact]
        public void —heckKeyFalse2()
        {
            Encryption encryption = new Encryption();
            var check = encryption.Encrypt("hello", "dsadasGDSfd", out string Cipher);
            Assert.False(check);
        }

        [Fact]
        public void —heckCryptOutPut()
        {
            Encryption encryption = new Encryption();
            var check = encryption.Encrypt("ass", "bra", out string Cipher);
            Assert.Equal("bjs", Cipher);
        }

    }
}
