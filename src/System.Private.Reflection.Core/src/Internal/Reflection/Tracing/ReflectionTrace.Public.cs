// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using global::System;
using global::System.Reflection;
using global::System.Diagnostics;
using global::System.Collections.Generic;
using global::System.Runtime.CompilerServices;

using ReflectionEventSource = global::System.Reflection.Runtime.Tracing.ReflectionEventSource;

namespace Internal.Reflection.Tracing
{
    [DeveloperExperienceModeOnly]
    public static partial class ReflectionTrace
    {
        public static bool Enabled
        {
            get
            {
                return ReflectionEventSource.IsInitialized && ReflectionEventSource.Log.IsEnabled();
            }
        }

        public static String GetTraceString(this TypeInfo typeInfo)
        {
            return typeInfo.NameString();
        }
    }
}


