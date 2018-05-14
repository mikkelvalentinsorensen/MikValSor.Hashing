using NUnit.Framework;

namespace MikValSor.Hashing.Test
{
	[TestFixture]
	public class HashImmutableTest
	{
		[Test]
		public void ImmutableTest()
		{
			//Arrange
			var validator = new MikValSor.Immutable.ImmutableValidator();
			var target = typeof(MikValSor.Security.Cryptography.Hash);

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}
	}
}
