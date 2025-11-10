using System;
using System.Net;
using System.Net.Http;
using UnityModManagerNet;

namespace RemoteAPI.Api
{
    public interface IEndpoint
    {
        HttpMethod HttpMethod { get; }
        string RoutePattern { get; }
        bool Matches(Uri uri);
        object Handle(UnityModManager.ModEntry.ModLogger logger, HttpListenerRequest request);
    }
}
