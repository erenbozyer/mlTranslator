using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mlTranslator  // <--- BURASI FORM1 İLE AYNI OLMALI
{
    public class ApiResponse
    {
        public ResponseData responseData { get; set; }
    }

    public class ResponseData
    {
        public string translatedText { get; set; }
    }

    public class CeviriServisi // <--- BAŞINDA 'public' YAZMASI ŞART
    {
        private readonly HttpClient _httpClient;

        public CeviriServisi()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> Cevir(string metin, string kaynakDil, string hedefDil)
        {
            string baseUrl = "https://api.mymemory.translated.net/get";
            string encodedMetin = Uri.EscapeDataString(metin);
            string url = $"{baseUrl}?q={encodedMetin}&langpair={kaynakDil}|{hedefDil}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonString = await response.Content.ReadAsStringAsync();
                ApiResponse veri = JsonConvert.DeserializeObject<ApiResponse>(jsonString);

                return veri.responseData.translatedText;
            }
            catch (Exception ex)
            {
                return "Hata: " + ex.Message;
            }
        }
    }
}