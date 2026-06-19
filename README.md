# Order Processing System

A lightweight, high-performance console backend application built with **.NET 10** to simulate a modern e-commerce order management system. 

The primary goal of this project is to master core backend development concepts in C#, focusing on architectural layer separation, asynchronous programming, multi-threading, and clean data modeling.

## Key Features & Concepts Covered

- **Three-Tier Architecture:** Complete separation of concerns between Data Models, Repositories (I/O simulation), and Business Logic Services.
- **Asynchronous Programming (TAP):** Efficient I/O simulation using `async/await` to keep threads non-blocking during database emulation.
- **Task Forwarding Optimization:** Memory and CPU optimization by transparently passing `Task` objects across layers without unnecessary state machine allocations.
- **Multi-Threading (CPU-Bound Isolation):** Offloading heavy price and discount computations to the Thread Pool using `Task.Run()`.
- **Modern C# Idioms:** Utilizing immutable `records`, `nullable reference types` for robust error handling, and expressive `pattern matching` (switch expressions).
- **Resource Management:** Safe disposal of system resources using the modern `using` statement.

## Project Structure

```text
OrderProcessingSystem/
│
├── Models/               # Data contracts and immutable records
│   ├── Client.cs         # Client entity (Supports VIP status)
│   └── Order.cs          # Order entity (Supports Nullable Guest accounts)
│
├── Repositories/         # Data Access Layer (In-memory DB & I/O simulation)
│   └── OrderRepository.cs
│
├── Services/             # Business Logic Layer (Discounts, Multi-threading)
│   └── OrderService.cs
│
├── Program.cs            # Application entry point (Controller simulation)
└── OrderProcessingSystem.csproj
```

## Tech Stack
•	Language: C# 14
•	Runtime: .NET 10.0.301
•	IDE: Visual Studio Code (with C# Dev Kit)
•	OS: macOS (Apple Silicon optimized)

## How to Run
	1.	Clone the repository:
``` bash
git clone https://github.com/HailReese/OrderProcessingSystemCLI.git
```

	2.	Navigate to the project directory:
cd OrderProcessingSystem

	3.	Restore dependencies and run the application:
dotnet run
