//
//  This file was auto-generated using the ChilliConnect SDK Generator.
//
//  The MIT License (MIT)
//
//  Copyright (c) 2015 Tag Games Ltd
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using SdkCore;

namespace ChilliConnect 
{
	/// <summary>
	/// <para>A container for information on an Economy Package File item.</para>
	///
	/// <para>This is immutable after construction and is therefore thread safe.</para>
	/// </summary>
	public sealed class EconomyPackageFileItem
	{
		/// <summary>
		/// The Economy Item name.
		/// </summary>
        public string Name { get; private set; }
	
		/// <summary>
		/// The Economy Item type. Possible values: CONVERSION, CURRENCY, INVENTORYITEM,
		/// METADATA, MONEYPURCHASE, VIRTUALPURCHASE.
		/// </summary>
        public string Type { get; private set; }
	
		/// <summary>
		/// The Economy Item key.
		/// </summary>
        public string Key { get; private set; }

		/// <summary>
		/// Initialises a new instance with the given properties.
		/// </summary>
		///
		/// <param name="name">The Economy Item name.</param>
		/// <param name="type">The Economy Item type. Possible values: CONVERSION, CURRENCY, INVENTORYITEM,
		/// METADATA, MONEYPURCHASE, VIRTUALPURCHASE.</param>
		/// <param name="key">The Economy Item key.</param>
		public EconomyPackageFileItem(string name, string type, string key)
		{
			ReleaseAssert.IsNotNull(name, "Name cannot be null.");
			ReleaseAssert.IsNotNull(type, "Type cannot be null.");
			ReleaseAssert.IsNotNull(key, "Key cannot be null.");
	
            Name = name;
            Type = type;
            Key = key;
		}
		
		/// <summary>
		/// Initialises a new instance from the given Json dictionary.
		/// </summary>
		///
		/// <param name="jsonDictionary">The dictionary containing the Json data.</param>
		public EconomyPackageFileItem(IDictionary<string, object> jsonDictionary)
		{
			ReleaseAssert.IsNotNull(jsonDictionary, "JSON dictionary cannot be null.");
			ReleaseAssert.IsTrue(jsonDictionary.ContainsKey("Name"), "Json is missing required field 'Name'");
			ReleaseAssert.IsTrue(jsonDictionary.ContainsKey("Type"), "Json is missing required field 'Type'");
			ReleaseAssert.IsTrue(jsonDictionary.ContainsKey("Key"), "Json is missing required field 'Key'");
	
			foreach (KeyValuePair<string, object> entry in jsonDictionary)
			{
				// Name
				if (entry.Key == "Name")
				{
                    ReleaseAssert.IsTrue(entry.Value is string, "Invalid serialised type.");
                    Name = (string)entry.Value;
				}
		
				// Type
				else if (entry.Key == "Type")
				{
                    ReleaseAssert.IsTrue(entry.Value is string, "Invalid serialised type.");
                    Type = (string)entry.Value;
				}
		
				// Key
				else if (entry.Key == "Key")
				{
                    ReleaseAssert.IsTrue(entry.Value is string, "Invalid serialised type.");
                    Key = (string)entry.Value;
				}
			}
		}

		/// <summary>
		/// Serialises all properties. The output will be a dictionary containing the
		/// objects properties in a form that can easily be converted to Json. 
		/// </summary>
		///
		/// <returns>The serialised object in dictionary form.</returns>
		public IDictionary<string, object> Serialise()
		{
            var dictionary = new Dictionary<string, object>();
			
			// Name
			dictionary.Add("Name", Name);
			
			// Type
			dictionary.Add("Type", Type);
			
			// Key
			dictionary.Add("Key", Key);
			
			return dictionary;
		}
	}
}
