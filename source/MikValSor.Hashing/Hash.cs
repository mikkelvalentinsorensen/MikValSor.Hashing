using MikValSor.Encoding;
using MikValSor.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace MikValSor.Security.Cryptography
{
	/// <summary>
	///		Class representing hash value of a serialized immutable object.
	/// </summary>
	[Serializable]
	public sealed class Hash : ImmutableCollectionBase<byte>, ISerializable
	{
		private Hash(ImmutableCollection<byte> bytes, HashAlgorithm algorithm) : base(bytes)
		{
			Algorithm = algorithm;
		}

		/// <summary>
		///		The hashing algorithm of value.
		/// </summary>
		public readonly HashAlgorithm Algorithm;
		
		public override string ToString()
		{
			return new Base64(this).ToString();
		}

		#region Serializable

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("B", this.ToImmutable());
			info.AddValue("A", Algorithm);
		}
		private Hash(SerializationInfo info, StreamingContext context) : base(info.GetValue("B", typeof(byte[])) as ImmutableCollection<byte>)
		{
			Algorithm = (HashAlgorithm)info.GetValue("A", typeof(HashAlgorithm));
		}

		#endregion Serializable

		/// <summary>
		///		Computes the hash value of the inputed byte array.
		/// </summary>
		/// <param name="bytes">
		///		The byte source for hash computation.
		/// </param>
		/// <param name="hashAlgorithm">
		///		Algorithm used for computation.
		/// </param>
		/// <returns>
		///		Returns computed hash value.
		/// </returns>
		public static Hash Compute(IEnumerable<byte> bytes, HashAlgorithm hashAlgorithm = HashAlgorithm.SHA512)
		{
			if (bytes == null) throw new ArgumentNullException(nameof(bytes));
			var hashingProvider = HashProvider.Get(hashAlgorithm);
			var hash = hashingProvider.ComputeHash(bytes.ToArray());
			return new Hash(hash.ToImmutable(), hashAlgorithm);
		}
	}
}
