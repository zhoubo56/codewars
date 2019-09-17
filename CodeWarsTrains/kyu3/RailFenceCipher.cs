namespace kyu3
{
    /// <summary>
    /// Rail Fence Cipher: Encoding and Decoding
    /// https://www.codewars.com/kata/rail-fence-cipher-encoding-and-decoding
    /// </summary>
    public class RailFenceCipher
    {
        public static string Encode(string s, int n)
        {
            var strArray = new string[n];
            var flag = 0;
            var option = true;
            foreach (var c in s)
            {
                strArray[flag] += c;
                if (option)
                {
                    flag++;
                    if (flag == n - 1) option = false;
                }
                else
                {
                    flag--;
                    if (flag == 0) option = true;
                }
            }
            return string.Join("", strArray);
        }

        public static string Decode(string s, int n)
        {
            var charArray = new char[s.Length];
            var index = 0;
            var line = 1;
            var option = true;
            foreach (var c in s)
            {
                charArray[index] = c;
                if (option)
                {
                    index += (n - line) * 2;
                }
                else
                {
                    index += (line - 1) * 2;
                }

                if (line != 1 && line != n) option = !option;

                if (index < s.Length) continue;
                index = line;
                line++;
                option = line != n;
            }

            return string.Join("", charArray);
        }
    }
}
