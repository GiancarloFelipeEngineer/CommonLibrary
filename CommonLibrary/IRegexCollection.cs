namespace CommonLibrary
{
    public interface IRegexCollection : IDisposable
    {
        bool? IsValidCurlyBracket { get; set; }

        bool HasValidCrulyBrackets(string value);
    }
}