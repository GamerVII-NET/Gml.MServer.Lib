using System.Collections.Generic;

namespace Gml.MServer.Lib.DTOs;

internal class PurpurVersionsDto
{
    public string Project { get; set; }
    public List<string> Versions { get; set; }  
}