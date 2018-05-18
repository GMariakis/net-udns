﻿using Makaretu.Dns;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Makaretu.Dns
{
    
    [TestClass]
    public class IPAddressExtensionsTest
    {
        [TestMethod]
        public void ArpaName()
        {
            Assert.AreEqual("4.4.8.8.in-addr.arpa", IPAddress.Parse("8.8.4.4").GetArpaName());
            Assert.AreEqual("b.a.9.8.7.6.5.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.8.b.d.0.1.0.0.2.ip6.arpa", IPAddress.Parse("2001:db8::567:89ab").GetArpaName());
        }

    }
}
