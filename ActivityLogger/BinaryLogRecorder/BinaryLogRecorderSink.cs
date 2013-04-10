using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CK.Core;

namespace BinaryLogRecorder
{
    public class BinaryLogRecorderSink : IActivityLoggerClient
    {
        private const string FILE_NAME = "Logs.data";
        private BinaryWriter w;

        public BinaryLogRecorderSink()
        {
            if (File.Exists(FILE_NAME))
            {
                //Console.WriteLine("{0} already exists!", FILE_NAME);
                return;
            }
            FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew);
            // Create the writer for data.

            w = new BinaryWriter(fs);

        }

        void writeALog(string log)
        {
            using (w)
            {
                w.Write(log);
            }
        }

        public void OnFilterChanged(LogLevelFilter current, LogLevelFilter newValue)
        {
            throw new NotImplementedException();
        }

        public void OnGroupClosed(IActivityLogGroup group, string conclusion)
        {
            throw new NotImplementedException();
        }

        public string OnGroupClosing(IActivityLogGroup group, string conclusion)
        {
            throw new NotImplementedException();
        }

        public void OnOpenGroup(IActivityLogGroup group)
        {
            throw new NotImplementedException();
        }

        public void OnUnfilteredLog(LogLevel level, string text)
        {
            throw new NotImplementedException();
        }
    }
}
