namespace kyu4
{
    /// <summary>
    /// Snail
    /// https://www.codewars.com/kata/snail
    /// </summary>
    public class SnailSort
    {
        public static int[] Snail(int[][] array)
        {
            var totalCount = array.Length * array[0].Length;
            var result = new int[totalCount];
            var x = 0;
            var xOption = true;
            var y = 0;
            var yOption = true;
            var flag = 'x';
            for (var i = 0; i < totalCount; i++)
            {
                switch (flag)
                {
                    case 'x':
                        {
                            result[i] = array[x][y];
                            if (x + y == array[x].Length - 1)
                            {
                                x = yOption ? x + 1 : x - 1;
                                flag = 'y';
                                xOption = !xOption;
                                continue;
                            }

                            y = xOption ? y + 1 : y - 1;
                            break;
                        }
                    case 'y':
                        {
                            result[i] = array[x][y];
                            if ((yOption && x == y)
                                || (!yOption && x == y + 1))
                            {
                                y = xOption ? y + 1 : y - 1;
                                flag = 'x';
                                yOption = !yOption;
                                continue;
                            }

                            x = yOption ? x + 1 : x - 1;
                            break;
                        }
                }
            }

            return result;
        }
    }
}
