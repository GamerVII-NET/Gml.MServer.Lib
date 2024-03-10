using Gml.MServer.Lib.Interfaces;

namespace Gml.MServer.Lib.Models;

public record ServerVersion(string Version, string Type) : IMinecraftVersion;