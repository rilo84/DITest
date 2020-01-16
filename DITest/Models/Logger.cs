using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DITest
{
    public class Logger : ILogger
    {
        private static Logger _logger = null;

        private Logger()
        {

        }
        public static Logger GetInstance { get
            {
                if(_logger == null) _logger = new Logger();
                return _logger;
            }
        }
        
        public void Save(string text)
        {
            using (var sw = new StreamWriter(@"c:\Projekt\log.txt",true))
            {
                sw.WriteLine(text);
            };
        }
    }
}