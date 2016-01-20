using System.Collections.Generic;

namespace Test
{
    public interface ITextParser
    {
        IList<IWordFrequency> ParseText(string text);
    }
}
