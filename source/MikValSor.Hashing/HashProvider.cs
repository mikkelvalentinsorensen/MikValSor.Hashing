using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace MikValSor.Security.Cryptography
{
	internal static class HashProvider
	{
		private static Lazy<Dictionary<HashAlgorithm, Lazy<System.Security.Cryptography.HashAlgorithm>>> lazyDictionary = new Lazy<Dictionary<HashAlgorithm, Lazy<System.Security.Cryptography.HashAlgorithm>>>(() => CreateDictionary());
		private static Dictionary<HashAlgorithm, Lazy<System.Security.Cryptography.HashAlgorithm>> Dictionary => lazyDictionary.Value;

		private static Dictionary<HashAlgorithm, Lazy<System.Security.Cryptography.HashAlgorithm>> CreateDictionary()
		{
			return new Dictionary<HashAlgorithm, Lazy<System.Security.Cryptography.HashAlgorithm>>()
			{
				{HashAlgorithm.SHA1, new Lazy<System.Security.Cryptography.HashAlgorithm>(()=>new SHA1Managed()) },
				{HashAlgorithm.SHA256, new Lazy<System.Security.Cryptography.HashAlgorithm>(()=>new SHA256Managed()) },
				{HashAlgorithm.SHA384, new Lazy<System.Security.Cryptography.HashAlgorithm>(()=>new SHA384Managed()) },
				{HashAlgorithm.SHA512, new Lazy<System.Security.Cryptography.HashAlgorithm>(()=>new SHA512Managed()) }
			};
		}
		internal static System.Security.Cryptography.HashAlgorithm Get(HashAlgorithm hashAlgorithm)
		{
			return Dictionary[hashAlgorithm].Value;
		}
	}
}
