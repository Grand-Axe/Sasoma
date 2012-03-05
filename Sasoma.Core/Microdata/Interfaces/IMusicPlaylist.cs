using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface IMusicPlaylist : ICreativeWork
    {
        NumTracks_Core NumTracks { get; set; }
        Tracks_Core Tracks { get; set; }
    }
}
