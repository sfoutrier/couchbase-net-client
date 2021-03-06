﻿using System;
using Enyim.Caching.Memcached;
using System.Collections.Generic;
namespace Couchbase
{
	interface ICouchbaseClient
	{
		object Get(string key, DateTime newExpiration);
		T Get<T>(string key, DateTime newExpiration);
		CasResult<object> GetWithCas(string key, DateTime newExpiration);
		CasResult<T> GetWithCas<T>(string key, DateTime newExpiration);
		IDictionary<string, SyncResult> Sync(SyncMode mode, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, ulong>> items);
		SyncResult Sync(string key, ulong cas, SyncMode mode);
		SyncResult Sync(string key, ulong cas, SyncMode mode, int replicationCount);
		void Touch(string key, DateTime nextExpiration);
		void Touch(string key, TimeSpan nextExpiration);
		bool TryGet(string key, DateTime newExpiration, out object value);
		bool TryGetWithCas(string key, DateTime newExpiration, out Enyim.Caching.Memcached.CasResult<object> value);
	}
}

#region [ License information          ]
/* ************************************************************
 * 
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2012 Couchbase, Inc.
 *    
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *    
 *        http://www.apache.org/licenses/LICENSE-2.0
 *    
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *    
 * ************************************************************/
#endregion