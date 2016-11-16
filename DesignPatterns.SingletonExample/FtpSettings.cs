namespace DesignPatterns.SingletonExample
{
    public sealed class FtpSettings
    {
        public static FtpSettings Instance { get { return instance; } }

        private static readonly FtpSettings instance = new FtpSettings();

        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        static FtpSettings()
        {
        }

        private FtpSettings()
        {
            Host = "127.0.0.1";
            Port = 21;
            Username = "username";
            Password = "password";
        }
    }
}
