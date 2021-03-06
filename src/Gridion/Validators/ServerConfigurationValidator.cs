﻿// <copyright file="ServerConfigurationValidator.cs" company="Gridion">
//     Copyright (c) 2019-2020, Alex Efremov (https://github.com/alexander-efremov)
// </copyright>
// 
// Licensed to the Apache Software Foundation (ASF) under one or more
// contributor license agreements.  See the NOTICE file distributed with
// this work for additional information regarding copyright ownership.
// The ASF licenses this file to You under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with
// the License.  You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// The latest version of this file can be found at https://github.com/gridion/gridion

namespace Gridion.Core.Validators
{
    using System.Net;

    using Gridion.Core.Configurations;
    using Gridion.Core.Utils;

    /// <summary>
    ///     Represents a set of operation to validate <see cref="GridionServerConfiguration" /> instances.
    /// </summary>
    internal static class ServerConfigurationValidator
    {
        /// <summary>
        ///     Validates <see cref="GridionServerConfiguration" /> instance.
        /// </summary>
        /// <param name="configuration">
        ///     The configuration to validate.
        /// </param>
        internal static void Validate(GridionServerConfiguration configuration)
        {
            Should.NotBeNull(configuration, nameof(configuration));
            Should.BeTrue(IPAddress.TryParse(configuration.Host, out _), nameof(configuration.Host));
            Should.BePositive(configuration.Port, nameof(configuration.Port));
        }
    }
}