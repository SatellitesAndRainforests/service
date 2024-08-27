namespace service.Application.Extensions
{
    public static class StringExtensions
    {

        public static bool StringNullCheck(this string? value)
        {
            if (value != null) return true;
            return false;
        }

    }
}
