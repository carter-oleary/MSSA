# Week 11 Notes
## Managed Code
### Required Classes
- `CodeCompileUnit()`
  - First step, represents entire assembly
- `CodeNamespace(string)`
  - Name of the namespace for managed code
- `CodeNamespaceImport("System")`
- `CodeTypeDeclaration("Program")`
- `CodeEntryPointMethod()`
  - Place to begin executing code (`main`)
- `CSharpCodeProvider()`
  - Tells me to generate a .cs file
- `CodeGeneratorOptions`
  - Provides options for generated code
### Applications
- Scaffolding
