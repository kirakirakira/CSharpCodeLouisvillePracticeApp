using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PracticeApp
{
    internal class Program
    {
        private static bool ShowMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Main Menu:");

            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].Choice}");
            }

            int userChoice = Library.GetNumber("Enter your choice: ");

            Console.WriteLine("\n");
            Console.WriteLine($"Your choice was {userChoice}");

            if (userChoice > items.Count)
            {
                Console.WriteLine("You failed to make a valid choice, too bad!");
                Console.WriteLine("Just kidding, try again");
                return false;
            }
            else
            {
                return items[userChoice - 1].ExecuteChoice();
            }
        }
        static List<IMenuItem> items = new List<IMenuItem>()
        {
            new AddTwoNumbers(),
            new SubtractTwoNumbers(),
            new RemoveWhitespace(),
            new ReverseAString(),
            new Exit()
        };

        private static readonly HttpClient client = new HttpClient();
        private static async Task<string> GetWeather()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/geo+json"));
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (X11; Linux x86_64; rv:97.0) Gecko/20100101 Firefox/97.0");

            var stringTask = client.GetStringAsync("https://api.weather.gov/gridpoints/LMK/57,81/forecast/hourly");

            var msg = await stringTask;
            return msg;
        }

        public static async Task Main(string[] args)
        {
            // var keepGoing = true;
            // while (keepGoing)
            // {
            //     keepGoing = ShowMenu();
            // }

            // var msg = await GetWeather();
            // var objData = (JObject)JsonConvert.DeserializeObject(msg);
            // Console.WriteLine(objData);

            var json = await GetWeather();
            dynamic weather = JObject.Parse(json);
            Console.WriteLine(weather);

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
