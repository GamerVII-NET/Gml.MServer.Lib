using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Gml.MServer.Lib.Interfaces;
using Gml.MServer.Lib.Loaders;

namespace Gml.MServer.Lib;

public class GmlServerManager
{

    public GmlServerManager()
    {
        
    }


    public async Task<IEnumerable<IMinecraftServer>> GetServersAsync()
    {
        
        
        
        return Enumerable.Empty<IMinecraftServer>();
    }

    public async Task<IEnumerable<IMinecraftVersion>> GetVersionsAsync()
    {
        var purpurVersions = await PurpurLoader.GetVersions();
        
        return purpurVersions;
    }
    
}