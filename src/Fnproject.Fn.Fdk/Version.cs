namespace Fnproject.Fn.Fdk
{
    sealed class Version
    {
        private static readonly string version = "0.0.12";

        private Version() { }

        public static string Value
        {
            get { return version; }
            private set {}
        }
    }
}