## Dynamic Objects
- Do not conform to strongly type object model
- Enable you to take advantage of dynamic languages (IronPython)
- Simplify process of interopetrating w unmanaged code
  - **Unmanaged**: Anything not developed in .NET
    - **Ex:** Word, python
  - **DLR:** Dynamic Language Runtime, CLR for unmanaged code
    - Run-time type checking for dynamic objects
    - Language bunders to handle details of interoperating with another language
### Creating a Dynamic Object
- Declared using the `dynamic` keywork
  - `dynamic word = new Application();`
- Can access members using dot notation like other classes
- Do NOT need to
  - Use ref keyword
  - Refer to parameters as type `object`
# Managing the Lifetime of Objects and Controlling Unmanaged Resources
- **Destructor**: `~ClassName()`, more prevalent in C++ to free up resources
- This is handled by the garbage collector in C#
### CLR
- Handles
  1. MSIL into native code by calling JIT compiler
  2. Execution of code
  3. Memory Management
  4. Calling garbage collector if needed
- When the heap area is being exhausted (running out of memory), the CLR calls the GC   
## The Object Life Cycle

## Implementing the Dispose Pattern
- GC will not dispose of unmanaged resources
- Recommended to implement a dispose method or destructor in any dynamic objects
- Prioritize a dispose method (IDisposable) over finalizer/destructor to minimize load on the GC 
  - Destructors will add object to the FReachable Q
  - Dispose() will suppress the finalizer (deterministic)
- If not called, Dispose() will be automatically called when the object is no longer in scope
## Managing the Lifetime of an Object
- [Garbage Collection](https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals)

# Encrypting and Decrypting Data
## Symmetric Encryption
### What is it?
- Symmetric encryption is the cryptographic transformation of data using a mathematical algorithm
- The same key is used to encrypt and decrypt data
- `System.Security.Cryptography`
  - `DESCryptoServiceProvider` Class
  - `AESManaged` class
  - `RC2CryptoServiceProvider` class
  - And more!
- Advantages
  - No limit to the amount of data you can encrypt
  - Fast, use less system resources
- Disadvantages
  - Same key
- Steps
  1. Create an `Rfc2898DeriveBytes` object
  2. Create an `AESManaged` object
  3. Generate secret key and IV (initial vector)
     - IV creates a different encryption on the first data to be encrypted to protect the key
  4. Create stream to buffer transformed data
  5. Create symmetric encryptor or decryptor object
  6. Create `CryptoStream` object
  7. Write transformed data to buffer streams
  8. Close streams
### Hashing Data
- A hash is a numerical representation of a piece of data
## Asymmetric Encryption
- Asymmetric encryption uses
  - A public key to encrypt data
  - A private key to decrypt data
- `System.Security.Cryptography` includes
  - `RSACryptoServiceProvider` class
  - `DSACryptoServiceProvider` class
- Uses larger keys than symmetric keys
- Limit on amount of data that can be encrypted (dependent on key size/algorithm)
- slower
- Data Encryption: Symmetric
- Key Encryption: Asymmetric

# .NET MAUI
- Allows to  build apps on any platform on one unified platform
  - Single shared codebase that works on any platform
## What it is
- An open-source app platform from MSFT for building modern, performany and multi-platform iOS, Android, macOS, and Windows apps w C# and .NET from a single shared codebase
- .NET Multi-platform App UI (MAUI)
## MVC
### View
- Front End
### Model
- Domain classes
### View-Model
- Connection bt front and back end
### Resources
- Cross platform resources
[Learning Resource](https://learn.microsoft.com/en-us/training/paths/build-apps-with-dotnet-maui/)
[.NET MAUI Shell](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/?view=net-maui-9.0)








