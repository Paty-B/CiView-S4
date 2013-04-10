using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using CK.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinaryLogRecorder;

namespace BinaryLogRecorder.Tests
{
    [TestFixture]
    public class BinaryLogRecorderSinkTests
    {
        IDefaultActivityLogger logger = DefaultActivityLogger.Create();

        public void BinaryLogRecorderRegistred()
        {  
            BinaryLogRecorderSink log = new BinaryLogRecorderSink();
            //logger.Register(log);
        }

        [Test]
        public void TestMethod1()
        {
            using (logger.OpenGroup(LogLevel.Trace, () => "EndMainGroup", "MainGroup"))
            {
                logger.Trace("First");
                logger.Trace("Second");
                logger.Trace("Third");
                logger.Info("last");
                using (logger.OpenGroup(LogLevel.Info, () => "EndInfoGroup", "InfoGroup"))
                    {
                        logger.Info("Second");
                        logger.Trace("Fourth");
                         using (logger.OpenGroup(LogLevel.Warn, () => "EndWarnGroup", "WarnGroup"))
                       {
                             logger.Info("Warn!");
                       }
                    }
            }
        }
    }
}
