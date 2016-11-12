using System;
using System.IO;

namespace DesignPatterns.Singleton_ExceptionHandlerExample
{
    public class ExceptionHandler
    {
        static ExceptionHandler _instance;
        static readonly object _lock = new object();
        StreamWriter _streamWriter;

        public ExceptionHandler Instance
        {
            get
            {
                // makes this thread-safe, you could avoid it entirely and not have the lazy-loading
                // it depends how expensive it is to new up the exception handler
                // in this case, you actually would be better newing it up in the private declaration above

                lock (_lock)
                {
                    // lazy-load
                    if (_instance == null)
                    {
                        _instance = new ExceptionHandler();
                    }
                }

                return _instance;
            }
        }

        private ExceptionHandler()
        {
            _streamWriter = new StreamWriter(@"C:\Log.txt");
        }

        public void WriteExceptionLog(Exception ex)
        {
            _streamWriter.WriteLine(ex.Message);
            _streamWriter.Flush();
        }
    }
}
