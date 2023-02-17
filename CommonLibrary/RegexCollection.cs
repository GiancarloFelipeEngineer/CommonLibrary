using System.Text.RegularExpressions;

namespace CommonLibrary
{
    public class RegexCollection : IRegexCollection
    {
        private bool disposedValue;

        public const string VALID_CURLYBRACKETS_PATTERN = "^{[^}]*[$}]*}";
        public const string INVALID_CURLYBRACKETS_PATTERN = "^}[^{]*[${]*{";
        public const string UNCLOSE_CURLYBRACKETS_PATTERN = "^{{[^}]*[$}]*}";

        public bool? IsValidCurlyBracket { get; set; }

        private void DefaultObjects()
        {
            this.IsValidCurlyBracket = false;
        }

        public RegexCollection()
        {
            this.IsValidCurlyBracket = null;
        }
        public Boolean HasValidCrulyBrackets(string value)
        {
            bool isValid = false;
            Regex rgx = new Regex(VALID_CURLYBRACKETS_PATTERN, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(value);
            using (RegexCollection regexCollection = new RegexCollection())
            {
                if (regexCollection.IsInValidCrulyBrackets(value))
                {
                    isValid = false;
                }
                else if (regexCollection.IsOneCrulyBracketsPairNotClosed(value))
                {
                    isValid = false;
                }
                else if (regexCollection.IsValidCrulyBrackets(value))
                {
                    isValid = true;
                }
                else if (regexCollection.IsDoesNotContainCrulyBrackets(value))
                {
                    isValid = true;
                }
            }
            this.IsValidCurlyBracket = isValid;
            return isValid;
        }

        private Boolean IsValidCrulyBrackets(string value)
        {
            bool isValid = false;
            Regex rgx = new Regex(VALID_CURLYBRACKETS_PATTERN, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(value);
            if (matches.Count > 0)
            {
                isValid = true;
            }
            return isValid;
        }

        private Boolean IsInValidCrulyBrackets(string value)
        {
            bool isValid = false;
            Regex rgx = new Regex(INVALID_CURLYBRACKETS_PATTERN, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(value);
            if (matches.Count > 0)
            {
                isValid = true;
            }
            return isValid;
        }

        private Boolean IsOneCrulyBracketsPairNotClosed(string value)
        {
            bool isValid = false;
            Regex rgx = new Regex(UNCLOSE_CURLYBRACKETS_PATTERN, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(value);
            if (matches.Count > 0)
            {
                isValid = true;
            }
            return isValid;
        }

        private Boolean IsDoesNotContainCrulyBrackets(string value)
        {
            bool isValid = false;

            if (!(value.Contains("{") || value.Contains("}")))
            {
                isValid = true;
            }
            return isValid;
        }

        private void ReleaseObjects()
        {
            this.IsValidCurlyBracket = null;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    this.ReleaseObjects();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~RegexCollection()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
