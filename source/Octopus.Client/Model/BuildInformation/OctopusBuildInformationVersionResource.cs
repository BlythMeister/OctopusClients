﻿
namespace Octopus.Client.Model.BuildInformation
{
    public class OctopusBuildInformationVersionResource : Resource
    {
        public string PackageId { get; set; }
        public string Version { get; set; }

        public OctopusBuildInformation OctopusBuildInformation { get; set; }
    }
}