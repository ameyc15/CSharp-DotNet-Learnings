using System.Text;

namespace Day41_BasicAuthEncrypted
{
    public static class BasicAutherisationHelper
    {
        public static bool IsAutherised(HttpRequest request)
        {
            if (!request.Headers.ContainsKey("Authorization"))
            {
                return false;
            }

            var authHeader = request.Headers["Authorization"].ToString();
            if(!authHeader.StartsWith("Basic "))
            {
                return false ;
            }

            var encodedValue = authHeader.Substring("Basic".Length).Trim();
            var decodedValue = Convert.FromBase64String(encodedValue);
            var credentials = Encoding.UTF8.GetString(decodedValue).Split(":");

            var authHeaderUsername = credentials[0];
            var authHeaderPassword = credentials[1];

            return authHeaderUsername == "admin" && authHeaderPassword == "admin123";
        }
    }
}
