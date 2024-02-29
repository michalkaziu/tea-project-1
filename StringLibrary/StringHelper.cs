using System;
using System.Text;

namespace StringLibrary;

public static class StringHelper
{
    public static bool CutFromHtml(ref string html, string search, string opening, string closing)
    {
        var searchIndex = html.IndexOf(search);
        if (searchIndex == -1)
            return false;

        var openingIndex = html.Substring(0, searchIndex).LastIndexOf(opening);
        if (openingIndex == -1)
            return false;

        var closingIndex = html.IndexOf(closing, searchIndex);
        if (closingIndex == -1)
            return false;

        var sb = new StringBuilder();
        sb.Append(html.Substring(0, openingIndex));
        sb.Append(html.Substring(closingIndex + closing.Length));

        html = sb.ToString();
        return true;
    }
}