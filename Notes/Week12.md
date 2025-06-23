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
