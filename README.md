# InventorySystem-EmilyCarter
C# Project S.1
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

## Running Tests
```bash
dotnet test InventorySystem.Tests/InventorySystem.Tests.csproj
```

## Running the App
```bash
dotnet run --project InventorySystem-EmilyCarter/InventorySystem_EmilyCarter.csproj
```
