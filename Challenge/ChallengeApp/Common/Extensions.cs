namespace ChallengeApp.Common
{
    public static class Extensions
    {
        public static bool IsBracketsBalanced(this string value)
        {
            var response = true;
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < value.Length; i++)
            {
                switch (value[i])
                {
                    case Constants.OpenBracket:
                        stack.Push(value[i]);
                        break;
                    case Constants.CloseBracket:
                        if (stack.Count == 0)
                        {
                            response = false;
                            break;
                        }
                        else
                            stack.Pop();
                        break;
                    default:
                        continue;
                }
            }
            if (stack.Count > 0)
                response = false;

            return response;
        }

        public static int IndexOfItem (this object[] array, object item) => array.ToList().IndexOf(item) + 1;
    }
}
