using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
    public enum LogLevel
    {
        VERBOSE = 0,
        INFO = 10,
        WARNING = 20,
        ERROR = 30,
    }

    public class SimpleLoggerConfig
    {
        private string _LogDirectoryName = @"C:\LOG\";
        private string _LogFileName = "{0}-{1}.log";
        private string _LogFileGroup = "XrmAppLog";
        private LogLevel _logLevel = LogLevel.VERBOSE;

        public string LogDirectoryName
        {
            set
            {
                this._LogDirectoryName = value;
            }
            get
            {
                return this._LogDirectoryName;
            }
        }

        public string LogFileName
        {
            set
            {
                this._LogFileName = value;
            }
            get
            {
                return this._LogFileName;
            }
        }

        public string LogFileGroup
        {
            set
            {
                this._LogFileGroup = value;
            }
            get
            {
                return this._LogFileGroup;
            }
        }

        public LogLevel logLevel
        {
            set
            {
                this._logLevel = value;
            }
            get
            {
                return this._logLevel;
            }
        }

    }
}
