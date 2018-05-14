namespace MikValSor.Security.Cryptography
{
	/// <summary>
	///		Enumarator used for representing hashing algorithmes
	/// </summary>
    public enum HashAlgorithm
    {
		/// <summary>
		///		SHA1 produces a 160-bit (20-byte) hash value.
		/// </summary>
		SHA1 = 0,

		/// <summary>
		///		SHA256 produces a 256-bit (32-byte) hash value.
		/// </summary>
		SHA256 = 1,

		/// <summary>
		/// 	SHA384 produces a 384-bit (48-byte) hash value.
		/// </summary>
		SHA384 = 2,

		/// <summary>
		///		SHA512 produces a 512-bit (64-byte) hash value.
		/// </summary>
		SHA512 = 4
	}
}
