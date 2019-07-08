using System.Linq;

namespace PhoneBook.Utils {
    public static class StringUtil {
        public static string RemoveAllSpaces(string inputString) {
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (string.IsNullOrEmpty(inputString)) return "";
            return new string(inputString.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray());
        }

        public static bool IsANumber(string inputString) {
            return int.TryParse(RemoveAllSpaces(inputString), out _);
        }

        public static string ClampStringAtLimits(string inputString, int low, int high) {
            if (low < 0) low = 0;
            if (high < 0 || low >= high || string.IsNullOrWhiteSpace(inputString)) return "";

            return inputString.Substring(low, high);
        }
    }
}