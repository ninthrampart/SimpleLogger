using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
    public class SimpleLogger
    {

        private Boolean _dologging = true;
        private SimpleLoggerConfig _config = new SimpleLoggerConfig();

        private FileStream _fileStream;

        public SimpleLogger()
        {
            this.init(_config);
        }

        public SimpleLogger(string logFileName)
        {
            _config.LogFileName = logFileName;
            init(_config);
        }

        public SimpleLogger(SimpleLoggerConfig config)
        {
            this._config = config;
            init(config);
        }

        public Boolean doLogging
        {
            set
            {
                this._dologging = value;
            }
            get
            {
                return this._dologging;
            }
        }

        private string getDateTimeString()
        {
            return DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff");
        }

        private string getDateString()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }

        private string getFileName()
        {
            return String.Format(_config.LogFileName, this.getDateString(), _config.LogFileGroup);

        }

        private void init(SimpleLoggerConfig config)
        {
            string _LogDirectoryName = config.LogDirectoryName.EndsWith(@"\") ? config.LogDirectoryName : config.LogDirectoryName + @"\";

            string path = String.Format("{0}{1}", _LogDirectoryName, this.getFileName());
            _fileStream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
        }

        public void close()
        {
            _fileStream.Close();
        }

        private void writeFile(string message)
        {
            string line = this.getDateTimeString() + message + Environment.NewLine;
            byte[] info = new UTF8Encoding(true).GetBytes(line);
            this._fileStream.Write(info, 0, info.Length);
            this._fileStream.Flush();
        }

        public void valert(string msg)
        {
            if (this._dologging && _config.logLevel <= LogLevel.VERBOSE)
            {
                writeFile(" :: VERBOSE :: " + msg);
            }
        }

        public void ialert(string msg)
        {
            if (this._dologging && _config.logLevel <= LogLevel.INFO)
            {
                writeFile(" :: INFO :: " + msg);
            }
        }

        public void walert(string msg)
        {
            if (this._dologging && _config.logLevel <= LogLevel.WARNING)
            {
                writeFile(" :: WARNINIG :: " + msg);
            }
        }

        public void ealert(string msg)
        {
            if (this._dologging && _config.logLevel <= LogLevel.ERROR)
            {
                writeFile(" :: ERROR :: " + msg);
            }
        }
    }
}
