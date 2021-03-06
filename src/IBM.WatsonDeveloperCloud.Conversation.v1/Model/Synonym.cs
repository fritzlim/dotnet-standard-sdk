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

using Newtonsoft.Json;
using System;

namespace IBM.WatsonDeveloperCloud.Conversation.v1.Model
{
    /// <summary>
    /// Synonym.
    /// </summary>
    public class Synonym : BaseModel
    {
        /// <summary>
        /// The text of the synonym.
        /// </summary>
        /// <value>The text of the synonym.</value>
        [JsonProperty("synonym", NullValueHandling = NullValueHandling.Ignore)]
        public string SynonymText { get; set; }
        /// <summary>
        /// The timestamp for creation of the synonym.
        /// </summary>
        /// <value>The timestamp for creation of the synonym.</value>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime Created { get; private set; }
        /// <summary>
        /// The timestamp for the most recent update to the synonym.
        /// </summary>
        /// <value>The timestamp for the most recent update to the synonym.</value>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime Updated { get; private set; }
    }

}
