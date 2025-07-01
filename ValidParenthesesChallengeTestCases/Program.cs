HelloWorld.Main([]);

public class HelloWorld
{
    private const char OPEN_PARENTHESES = '(';
    private const char CLOSE_PARENTHESES = ')';

    public static void Main(string[] args)
    {
        List<string> tests = GetTestCases();

        // test1: check if Parentheses Number is valid
        IsValidParentheses(tests);

        Console.WriteLine();

        // test2: check if the order of Parentheses is valid
        IsValidParenthesesOrder(tests);

        Console.WriteLine();

        // test2: version 2
        IsValidParenthesesOrderVersion2(tests);
    }

    public static List<string> GetTestCases()
    {
        List<string> tests = new List<string>();
        tests.Add("()");
        tests.Add("(())");
        tests.Add("(()");
        tests.Add(")(");
        tests.Add("()()");
        tests.Add("())");
        tests.Add("()())(");

        return tests;
    }

    public static void IsValidParentheses(List<string> tests)
    {
        foreach (string test in tests)
        {
            int openNum = 0;
            int closeNum = 0;

            foreach (char character in test)
            {
                if (character == OPEN_PARENTHESES)
                {
                    openNum++;
                }
                else if (character == CLOSE_PARENTHESES)
                {
                    closeNum++;
                }
            }
            Console.WriteLine($"test1={openNum == closeNum}");
        }
    }

    public static void IsValidParenthesesOrder(List<string> tests)
    {
        foreach (string test in tests)
        {
            int openNum = 0;
            int closeNum = 0;
            bool isValid = true;

            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] == OPEN_PARENTHESES)
                {
                    openNum++;
                }
                else if (test[i] == CLOSE_PARENTHESES)
                {
                    closeNum++;

                    if (closeNum > openNum)
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            Console.WriteLine($"test2={isValid && openNum == closeNum}");
        }
    }

    public static void IsValidParenthesesOrderVersion2(List<string> tests)
    {
        foreach (string test in tests)
        {
            int openAndCloseBalance = 0;

            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] == OPEN_PARENTHESES)
                {
                    openAndCloseBalance++;
                }
                else if (test[i] == CLOSE_PARENTHESES)
                {
                    openAndCloseBalance--;
                }

                if (openAndCloseBalance < 0)
                {
                    break;
                }
            }
            Console.WriteLine($"test2_v2={openAndCloseBalance == 0}");
        }
    }
}