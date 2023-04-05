using System.Text.RegularExpressions;

namespace VerificationSaisie
{
    public static class VerifierSaisie
    {
        public static bool MatchForInt(string str) => MatchFor(str, "^[0-9]{1,11}");
        private static bool MatchFor(string str, string regex)
        {
            Regex rg = new Regex(regex);
            return rg.IsMatch(str);
        }
    }
}