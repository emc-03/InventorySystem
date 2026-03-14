# InventorySystem-EmilyCarter

A C# WinForms inventory management application modernized with DevOps practices, including unit testing and CI/CD.

## Tech Stack

- **Language:** C# (.NET 10.0)
- **UI Framework:** WinForms
- **Testing:** xUnit
- **CI/CD:** GitHub Actions *(coming soon)*

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
| `ValidateMinMaxValues_ValidInputs_ReturnsTrue` | Valid min/max returns true | Passing |

## What I Learned

- Separation of concerns — extracting pure logic from WinForms-coupled classes to make them unit testable
- xUnit testing fundamentals — Arrange/Act/Assert pattern
- Professional solution structure with a separate test project
