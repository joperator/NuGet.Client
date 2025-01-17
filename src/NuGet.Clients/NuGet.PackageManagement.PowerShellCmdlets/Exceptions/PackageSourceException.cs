// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace NuGet.PackageManagement.PowerShellCmdlets
{
    [Serializable]
    public class PackageSourceException : Exception
    {
        public PackageSourceException(string message)
            : base(message)
        {
        }
    }
}
