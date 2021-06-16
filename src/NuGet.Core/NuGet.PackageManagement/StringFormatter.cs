// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace NuGet.PackageManagement
{
    internal static class StringFormatter
    {
        internal static string Log_PackageNamespacePrefixMatchFound(
            string packageId,
            string packageSourcesAtPrefix)
        {
            return string.Format(Strings.PackageNamespacePrefixMatchFound,
                packageId,
                packageSourcesAtPrefix
                );
        }

        internal static string Log_PackageNamespacePrefixNoMatchFound(
            string packageId)
        {
            return string.Format(Strings.PackageNamespacePrefixNoMatchFound,
                packageId
                );
        }

        internal static string Log_PackageNamespacePrefixSkipSource(
            string pacakgeSourceName,
            string packageId)
        {
            return string.Format(Strings.PackageNamespacePrefixSkipSource,
                pacakgeSourceName,
                packageId);
        }

        internal static string Log_PackageNamespacePrefixTrySource(
            string pacakgeSourceName,
            string packageId)
        {
            return string.Format(Strings.PackageNamespacePrefixTrySource,
                pacakgeSourceName,
                packageId);
        }
    }
}