using NUnit.Framework;

namespace MikValSor.Hashing.Test
{
	[TestFixture]
	public class HashSerilizableTest
	{
		[Test]
		public void SerializableTest()
		{
			var validator = new MikValSor.Runtime.Serialization.SerializableValidator();
			var target = typeof(MikValSor.Security.Cryptography.Hash);

			//Act
			validator.EnsureSerializable(target);

			//Assert
		}
	}
}
