.NET library for hashing in immutable value based style.

Nuget package: [https://www.nuget.org/packages/MikValSor.Hashing](https://www.nuget.org/packages/MikValSor.Hashing)

## Example:
```cs
void CreateHashExample()
{   
	var source = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7 };
	var algorithm = MikValSor.Security.Cryptography.HashAlgorithm.SHA1;

	var hash = MikValSor.Security.Cryptography.Hash.Compute(source, algorithm);

	System.Console.WriteLine($"hash.Base64: {hash}");
}
/**
	Output:
	hash: Z0I+v6hFTxmsb0aG1sDccxo93Ws=
**/
```