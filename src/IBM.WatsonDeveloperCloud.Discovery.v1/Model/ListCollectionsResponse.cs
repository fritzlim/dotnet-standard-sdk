/**
* Copyright 2017 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.Discovery.v1.Model
{
    /// <summary>
    /// ListCollectionsResponse.
    /// </summary>
    public class ListCollectionsResponse
    {
        /// <summary>
        /// An array containing information about each collection in the environment.
        /// </summary>
        /// <value>An array containing information about each collection in the environment.</value>
        [JsonProperty("collections", NullValueHandling = NullValueHandling.Ignore)]
        public List<Collection> Collections { get; set; }
    }

}
