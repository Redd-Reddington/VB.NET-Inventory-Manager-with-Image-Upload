# 📦 VB.NET Inventory Manager

A Windows Forms inventory management system built with Visual Basic .NET in Visual Studio. This app allows users to add, update, delete, and view product records—complete with image uploads and SQL Server integration.

## 🚀 Features

- Add new products with name, category, price, quantity, and image
- Update and delete existing records
- Display all products in a DataGridView
- Load and preview product images from local files
- Connects to SQL Server using `System.Data.SqlClient`

## 🛠️ Requirements

- Windows OS
- [.NET Framework](https://dotnet.microsoft.com/en-us/download/dotnet-framework)
- Visual Studio (for editing or rebuilding)
- SQL Server Express or compatible instance
- A database named `ShopDB` with a `Products` table:
  ```sql
  CREATE TABLE Products (
      Id INT PRIMARY KEY IDENTITY,
      ProductName NVARCHAR(100),
      Category NVARCHAR(50),
      Price DECIMAL(10,2),
      Quantity INT,
      ProductImage VARBINARY(MAX)
  )


## 📦 How to Run

- Clone or download this repository.
- Open the .sln file in Visual Studio.
- Ensure your SQL Server instance is running and the connection string is correct.
- Build and run the project.
- Use the form to manage product records.


## 📁 Files

- Form1.vb: Main form logic and event handlers.
- Form1.Designer.vb: UI layout.
- README.md: Project overview.
- bin/Release/InventoryManager.exe: Optional compiled executable.

Made with ❤️ by **Redd✍️🔴**
