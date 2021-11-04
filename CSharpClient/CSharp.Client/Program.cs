using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranlationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = TranslationClient.CreateFromApiKey(Utilty.apiKey);
            var response = client.TranslateText("আমি বাংলাদেশী", LanguageCodes.English, LanguageCodes.Bengali);
            Console.WriteLine(response.TranslatedText);
        }
    }
}
