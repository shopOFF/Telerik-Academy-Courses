namespace WarMachines.Common
{
    using System;
    public static class Validator  // вместо да пише 1 същи валидации на 100 мест си правим този клас валидатор с няколко метода който ще ни праоверяеват !!
    {
        public static void CheckIfNull(object obj, string message = null) // тоест ако някой ни подаде месидж ок ще го ползваме по доло ако не пак ок !
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string text, string message = null)  // и това е вторият метод койтп ще валидаира стрингове дали са 0 или празни
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }
    }
}
