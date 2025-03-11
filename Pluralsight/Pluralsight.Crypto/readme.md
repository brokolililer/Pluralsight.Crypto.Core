# Pluralsight.Crypto.Core

**Pluralsight.Crypto.Core** is a cryptography library for .NET applications targeting **netcoreapp3.0**, **net5.0**, **net6.0**, **net7.0**, and **net8.0**. It provides a simple and secure way to perform common cryptographic operations such as encryption, decryption, hashing, and key generation.

---

## 📥 Installation

Install the package from NuGet:

```shell
dotnet add package Pluralsight.Crypto.Core
```

Alternatively, you can install it using the NuGet Package Manager:

```shell
Install-Package Pluralsight.Crypto.Core
```

### 🚀 Getting Started
### 1. Encrypting and Decrypting Data
Example of encrypting and decrypting a string:

```csharp
using Pluralsight.Crypto;

public class CryptoExample
{
    public void Run()
    {
        var crypto = new CryptoService();

        string plainText = "Hello, World!";
        string encryptedText = crypto.Encrypt(plainText);
        string decryptedText = crypto.Decrypt(encryptedText);

        Console.WriteLine($"Original: {plainText}");
        Console.WriteLine($"Encrypted: {encryptedText}");
        Console.WriteLine($"Decrypted: {decryptedText}");
    }
}
```
#### 2. Generating a Hash
Example of generating a secure hash:

```csharp
using Pluralsight.Crypto;

public class HashExample
{
    public void Run()
    {
        var crypto = new CryptoService();

        string password = "MySecurePassword";
        string hash = crypto.GenerateHash(password);

        Console.WriteLine($"Password: {password}");
        Console.WriteLine($"Hash: {hash}");
    }
}
```
#### 3. Verifying a Hash
Example of verifying a hash:

```csharp
using Pluralsight.Crypto;

public class VerifyHashExample
{
    public void Run()
    {
        var crypto = new CryptoService();

        string password = "MySecurePassword";
        string hash = crypto.GenerateHash(password);

        bool isMatch = crypto.VerifyHash(password, hash);

        Console.WriteLine($"Password matches: {isMatch}");
    }
}
```
### ⚙️ Supported .NET Versions
#### Pluralsight.Crypto.Core supports the following frameworks:

* ✅ .NET Core 3.0
* ✅ .NET 5.0
* ✅ .NET 6.0
* ✅ .NET 7.0
* ✅ .NET 8.0
### ✅ Best Practices
* Use secure key management practices.
* Always verify hashes using a constant-time comparison method to prevent timing attacks.
* Encrypt sensitive data before storing or transmitting it.

### 🛠️ Configuration
#### You can configure encryption settings using the CryptoSettings class:

```csharp
var settings = new CryptoSettings
{
    KeySize = 256, // AES key size in bits
    BlockSize = 128, // AES block size in bits
    PaddingMode = PaddingMode.PKCS7
};

var crypto = new CryptoService(settings);
```
### 📝 License
This project is licensed under the MIT License. See the LICENSE file for details.

### 📫 Contact
For issues, questions, or feature requests, open an issue on GitHub.