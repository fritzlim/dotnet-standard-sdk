/**
* Copyright 2018 IBM Corp. All Rights Reserved.
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

namespace IBM.WatsonDeveloperCloud.Assistant.v1.Model
{
    /// <summary>
    /// ExampleCollection.
    /// </summary>
    public class ExampleCollection : BaseModel
    {
        /// <summary>
        /// An array of objects describing the examples defined for the intent.
        /// </summary>
        /// <value>An array of objects describing the examples defined for the intent.</value>
        [JsonProperty("examples", NullValueHandling = NullValueHandling.Ignore)]
        public List<Example> Examples { get; set; }
        /// <summary>
        /// The pagination data for the returned objects.
        /// </summary>
        /// <value>The pagination data for the returned objects.</value>
        [JsonProperty("pagination", NullValueHandling = NullValueHandling.Ignore)]
        public Pagination Pagination { get; set; }
    }

}
