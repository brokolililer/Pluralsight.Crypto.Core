﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.Crypto
{
    public class SelfSignedCertProperties
    {
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public X500DistinguishedName Name { get; set; }
        public int KeyBitLength { get; set; }
        public bool IsPrivateKeyExportable { get; set; }

        public SelfSignedCertProperties()
        {
            DateTime today = DateTime.Today;
            ValidFrom = today.AddDays(-1);
            ValidTo = today.AddYears(10);
            Name = new X500DistinguishedName("cn=self");
            KeyBitLength = 4096;
        }
    }
}
