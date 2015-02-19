﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Vipr.Core.CodeModel;

namespace Vipr.Core
{
    public interface IOdcmWriter
    {
        IDictionary<string, string> GenerateProxy(OdcmModel model);
    }
}