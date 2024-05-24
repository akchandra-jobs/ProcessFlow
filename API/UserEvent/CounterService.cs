using System.Text;

namespace ProcessFlow.Services
{
    public interface ICounterService
    {
        string GetCounter();
    }
    public class CounterService : ICounterService
    {
        private static readonly Random random = new Random();

        public string GetCounter()
        {
            int length = 10; // Length of the random string
            return GenerateRandomString(length);
        }

        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }
    }
}
