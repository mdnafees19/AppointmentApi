using System.Net.Http;
using System.Threading.Tasks;
namespace KfmmcAppointmentApi.Entities
{
    public class SmsService
    {
        private readonly HttpClient _httpClient;

        public SmsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> SendSmsAsync(string bearerToken, string sender, string recipient, string message)
        {
            try
            {
                // Ensure the message is URL-encoded
                string encodedMessage = System.Web.HttpUtility.UrlEncode(message);

                // Construct the API URL
                string apiUrl = $"https://api.taqnyat.sa/v1/messages?bearerTokens={bearerToken}&sender={sender}&recipients=966{recipient}&body={encodedMessage}";

                // Send the GET request
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                // Ensure the response is successful
                response.EnsureSuccessStatusCode();

                return true;
            }
            catch (Exception ex)
            {
                // Log the error (use a proper logging framework in production)
                Console.WriteLine($"Error sending SMS: {ex.Message}");
                return false;
            }
        }
    }
}
