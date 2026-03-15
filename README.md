# InventorySystem
![CI](https://github.com/emc-03/InventorySystem/actions/workflows/dotnet-ci.yml/badge.svg)
A C# WinForms inventory management application modernized with DevOps practices, including unit testing and CI/CD.

## Tech Stack

- **Language:** C# (.NET 10.0)
- **UI Framework:** WinForms
- **Testing:** xUnit
- **CI/CD:** GitHub Actions *(coming soon)*

## Version History

| Version | Framework | Notes |
|---------|-----------|-------|
| 1.0 | .NET 5.0-windows | Original submission |
| 2.0 | .NET 10.0-windows | Upgraded for long-term support, DevOps modernization |

## Upgrade Notes

This project was originally built targeting `net5.0-windows`, which reached end of life in May 2022.
As part of modernizing this project for the use of practicing and testing DevOps principles,  the target framework was
upgraded to `net10.0-windows` — the current LTS release — to ensure compatibility with modern
tooling, GitHub Actions runners, and current xUnit test frameworks.

**Changes made during upgrade:**
- Updated `<TargetFramework>` in `.csproj` from `net5.0-windows` to `net10.0-windows`
- Resolved NuGet package compatibility issues introduced by the framework change
- Added a separate xUnit test project targeting `net10.0-windows` to match the main project

## Project Structure
```
InventorySystem/
├── InventorySystem-EmilyCarter.sln        # Solution file
│
├── InventorySystem-EmilyCarter/           # Main project
│   ├── dataParts/
│   │   └── SelectionMode.cs
│   ├── helper/
│   │   └── validator.cs                   # Validation logic
│   ├── model/
│   │   ├── Inhouse.cs
│   │   ├── Inventory.cs
│   │   ├── Outsourced.cs
│   │   ├── Part.cs
│   │   └── Product.cs
│   ├── AddPart.cs
│   ├── addProducts.cs
│   ├── InventoryMain.cs
│   ├── modifyParts.cs
│   ├── ModifyProduct.cs
│   ├── Program.cs
│   └── InventorySystem_EmilyCarter.csproj
│
└── InventorySystem.Tests/                 # xUnit test project
    ├── ValidatorTests.cs                  # Unit tests for validator logic
    └── InventorySystem.Tests.csproj
```

## Running the App
```bash
dotnet run --project InventorySystem-EmilyCarter/InventorySystem_EmilyCarter.csproj
```

## Running Tests
```bash
dotnet test InventorySystem.Tests/InventorySystem.Tests.csproj
```

## Test Coverage

| Test | Description | Status |
|------|-------------|--------|
| `ValidateMinMaxValues_ValidInputs_ReturnsTrue` | Valid min/max returns true | ✅ Passing |
| `ValidateMinMaxValues_MinEqualsMax_ReturnsTrue` | Min equal to Max is allowed | ✅ Passing |
| `ValidateMinMaxValues_MinGreaterThanMax_ReturnsFalse` | Min greater than Max fails | ✅ Passing |
| `ValidateMinMaxValues_NegativeMax_ReturnsFalse` | Negative Max fails | ✅ Passing |
| `ValidateMinMaxValues_NegativeMin_ReturnsFalse` | Negative Min fails | ✅ Passing |

## What I Learned

- Separation of concerns — extracting pure logic from WinForms-coupled classes to make them unit testable
- xUnit testing fundamentals — Arrange/Act/Assert pattern
- Professional solution structure with a separate test project
- Framework migration from .NET 5.0 to .NET 10.0
- Git workflow — feature branches, pull requests, and clean commit history
