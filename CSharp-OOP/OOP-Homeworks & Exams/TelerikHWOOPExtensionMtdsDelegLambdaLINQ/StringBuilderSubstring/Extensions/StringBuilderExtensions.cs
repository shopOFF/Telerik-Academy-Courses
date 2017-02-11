namespace StringBuilderSubstring.Extensions
{
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder text,int index ,int length)
        {
            var result = new StringBuilder();
            string textAsString= text.ToString();

            for (int i = index; i < index + length; i++)
            {
                result.Append(textAsString[i]);
            }
            return result;
        }
    }
}
