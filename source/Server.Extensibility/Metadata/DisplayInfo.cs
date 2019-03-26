﻿namespace Octopus.Server.Extensibility.Metadata
{
    public class DisplayInfo
    {
        public bool Required { get; set; }

        public bool ReadOnly { get; set; }

        public string Label { get; set; }

        public string Description { get; set; }

        public OptionsMetadata Options { get; set; }

        public ListApiMetadata ListApi { get; set; }
        
        public bool ShowCopyToClipboard { get; set; }
    }
}