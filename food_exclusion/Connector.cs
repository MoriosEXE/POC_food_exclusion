using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace food_exclusion
{
    internal class Connector
    {
        public Connector() { }



        public async Task<String[]> Request(string barCode)
        {

            var client = new HttpClient();
            var result = await client.GetAsync($"https://world.openfoodfacts.org/api/v2/search?fields={barCode}");

            
            Console.WriteLine( result.EnsureSuccessStatusCode());
            String[] content = new[] { await result.Content.ReadAsStringAsync() };
            
            return content;
        }
    }
}
