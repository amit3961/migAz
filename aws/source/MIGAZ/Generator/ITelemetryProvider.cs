// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIGAZ.Generator
{
    public interface ITelemetryProvider
    {
        void PostTelemetryRecord(string AccessKey, Dictionary<string, string> processedItems, string Region);
    }
}

