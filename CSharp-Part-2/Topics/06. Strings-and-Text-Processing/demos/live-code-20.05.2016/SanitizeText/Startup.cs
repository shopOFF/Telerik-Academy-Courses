namespace SanitizeText
{
    using System;

    class Startup
    {
        // sanitize user input against XSS
        static void Main()
        {
            // < &#60;
            // > &#62;

            var html = @"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <title>Document</title>
</head>
<body>
    {0}
</body>
</html>";

            var badUsername = "<script>alert('hello gosho');</script>";

            var sanitized = badUsername
                                .Replace("<", "&#60;")
                                .Replace(">", "&#62;");

            Console.WriteLine(html, sanitized);
        }
    }
}
