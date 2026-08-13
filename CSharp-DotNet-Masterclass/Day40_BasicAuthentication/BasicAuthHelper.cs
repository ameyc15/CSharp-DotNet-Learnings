namespace Day40_BasicAuthentication
{
    public static class BasicAuthHelper
    {
        public static bool IsAuthorise(HttpRequest request)
        {
            if (!request.Headers.ContainsKey("username"))
            {
                return false;
            }

            if (!request.Headers.ContainsKey("password"))
            {
                return false;
            }

            var authHeaderUsername = request.Headers["username"].ToString();
            var authHeaderPassword = request.Headers["password"].ToString();

            return authHeaderUsername == "admin" && authHeaderPassword == "admin123";
        }
    }
}
