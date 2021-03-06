﻿using System;
using System.Collections.Generic;
using System.Text;

namespace hardforward.Encryption
{
    public interface IEncryptor : IDisposable
    {
        void Encrypt(byte[] buf, int length, byte[] outbuf, out int outlength);
        void Decrypt(byte[] buf, int length, byte[] outbuf, out int outlength);
    }
}
