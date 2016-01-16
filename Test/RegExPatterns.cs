namespace Test
{
    public static class RegExPatterns
    {
        public const string WordMatchPatternFormat = @"\b{0}\b";
        public const string AnyWordPattern = @"((\b[^\s]+\b)((?<=\.\w).)?)";
    }
}
