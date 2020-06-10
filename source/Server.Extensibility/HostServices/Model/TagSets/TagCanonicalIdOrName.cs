﻿using System;
using System.Linq;
using Octopus.TinyTypes;

namespace Octopus.Server.Extensibility.HostServices.Model.TagSets
{
    public class TagCanonicalIdOrName : CaseInsensitiveStringTinyType
    {
        public TagCanonicalIdOrName(string value) : base(value)
        {
            if (!LooksLikeACanonicalIdOrName(value))
                throw new ArgumentException("Value must look like a canonical tag ID or name");
        }

        internal static bool LooksLikeACanonicalIdOrName(string s)
        {
            var tokens = s.Split("/");
            if (tokens.Length != 2) return false;
            if (tokens.Any(string.IsNullOrWhiteSpace)) return false;
            return true;
        }
    }
}