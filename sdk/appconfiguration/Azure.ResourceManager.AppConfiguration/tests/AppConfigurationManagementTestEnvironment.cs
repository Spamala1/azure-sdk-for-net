// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.


using Azure.Core.TestFramework;

namespace Azure.ResourceManager.AppConfiguration.Tests
{
    public class AppConfigurationManagementTestEnvironment : TestEnvironment
    {
        public AppConfigurationManagementTestEnvironment() : base("appconfiguration")
        {
        }
    }
}
