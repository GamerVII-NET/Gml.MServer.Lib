using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Gml.MServer.Lib.DTOs;
using Gml.MServer.Lib.Interfaces;
using Gml.MServer.Lib.Models;
using Newtonsoft.Json;

namespace Gml.MServer.Lib.Loaders;

public class PurpurLoader
{
    public static async Task<IEnumerable<IMinecraftVersion>> GetVersions()
    {
        using (var client = new HttpClient())
        {
            var request = await client.GetAsync("https://api.purpurmc.org/v2/purpur");

            if (request.IsSuccessStatusCode)
            {
                var content = await request.Content.ReadAsStringAsync();

                var root = JsonConvert.DeserializeObject<PurpurVersionsDto>(content)
                           ?? throw new Exception("Not valid data from purpur");

                return root.Versions.Select(v => new ServerVersion(v, nameof(PurpurLoader)));
            }
        }

        return Enumerable.Empty<IMinecraftVersion>();
    }
}