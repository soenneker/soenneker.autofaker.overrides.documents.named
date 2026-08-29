[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.documents.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.documents.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.documents.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.documents.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.documents.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.documents.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.documents.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.documents.named/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Documents.Named

An AutoFaker override that populates identity fields on `NamedDocument` models.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Documents.Named
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.Documents.Named;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides = [new NamedDocumentOverride()];

ProductDocument document = autoFaker.Generate<ProductDocument>();
```

The override applies to `NamedDocument` and derived types. It assigns a commerce product name to `Name` and a GUID string to `Id`. Register a more specific override later when a derived document needs different identity data.
