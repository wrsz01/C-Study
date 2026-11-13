using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder(identifier.Length);
        bool afterHyphen = false;

        foreach (char c in identifier)
        {
            if (c == '-')
            {
                afterHyphen = true;
            }
            else if (char.IsWhiteSpace(c))
            {
                sb.Append('_');
                afterHyphen = false;
            }
            else if (char.IsControl(c))
            {
                sb.Append("CTRL");
                afterHyphen = false;
            }
            else if (char.IsLetter(c) && !(c >= 'α' && c <= 'ω'))
            {
                sb.Append(afterHyphen ? char.ToUpperInvariant(c) : c);
                afterHyphen = false;
            }
        }

        return sb.ToString();
    }
}