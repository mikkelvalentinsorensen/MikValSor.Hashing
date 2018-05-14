using NUnit.Framework;
using MikValSor.Security.Cryptography;
using System.Collections.Generic;

namespace MikValSor.Hashing.Test
{
	[TestFixture]
	public class HashTest
	{
		[Test]
		public void Hash_bytearray_SHA1()
		{
			//Arrange
			byte[] source = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			HashAlgorithm algorithm = HashAlgorithm.SHA1;

			//Act
			var actual = Hash.Compute(source, algorithm);

			//Assert
			Assert.IsNotNull(actual);
			var actualList = actual as IList<byte>;
			Assert.IsNotNull(actualList);
			Assert.AreEqual(20, actualList.Count);
			Assert.AreEqual("Z0I+v6hFTxmsb0aG1sDccxo93Ws=", actual.ToString());
			Assert.AreEqual(algorithm, actual.Algorithm);
		}

		[Test]
		public void Hash_bytearray_SHA256()
		{
			//Arrange
			byte[] source = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			HashAlgorithm algorithm = HashAlgorithm.SHA256;

			//Act
			var actual = Hash.Compute(source, algorithm);

			//Assert
			Assert.IsNotNull(actual);
			var actualList = actual as IList<byte>;
			Assert.IsNotNull(actualList);
			Assert.AreEqual(32, actualList.Count);
			Assert.AreEqual("ioUf+C7nBIrQnsOEfx3fRJRBBNLL0X7049sixnhaDUU=", actual.ToString());
			Assert.AreEqual(algorithm, actual.Algorithm);
		}

		[Test]
		public void Hash_bytearray_SHA384()
		{
			//Arrange
			byte[] source = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			HashAlgorithm algorithm = HashAlgorithm.SHA384;

			//Act
			var actual = Hash.Compute(source, algorithm);

			//Assert
			Assert.IsNotNull(actual);
			var actualList = actual as IList<byte>;
			Assert.IsNotNull(actualList);
			Assert.AreEqual(48, actualList.Count);
			Assert.AreEqual("z7GPgfS7ZysDIU8f7eRW+IKg3kASAhKh/rqP3Ej3Y8hqy7+2hNNLcPmfTY2B/joo", actual.ToString());
			Assert.AreEqual(algorithm, actual.Algorithm);
		}

		[Test]
		public void Hash_bytearray_SHA512()
		{
			//Arrange
			byte[] source = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			HashAlgorithm algorithm = HashAlgorithm.SHA512;

			//Act
			var actual = Hash.Compute(source, algorithm);

			//Assert
			Assert.IsNotNull(actual);
			var actualList = actual as IList<byte>;
			Assert.IsNotNull(actualList);
			Assert.AreEqual(64, actualList.Count);
			Assert.AreEqual("ikFMWGDPG+e8hTFEL2mmXvLs8LfK2ZlLy0Bwl+t0zLkuk6q9JL3mAzESO02QBoTKe+YCcJnUlGv1N/TWxt89gg==", actual.ToString());
			Assert.AreEqual(algorithm, actual.Algorithm);
		}
	}
}
