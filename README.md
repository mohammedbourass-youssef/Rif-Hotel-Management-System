# Rif Hotel Management System

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
  - [Prerequisites](#prerequisites)
  - [Steps](#steps)
- [Configuration](#configuration)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

---

## 🛎️ Introduction

**Rif Hotel Management System** is a complete desktop-based solution for managing hotel operations. Built using **C#** and **SQL Server**, this application empowers hotel staff and administrators to handle bookings, rooms, guests, billing, and reports efficiently. Its clean, modern interface (using **Guna UI2** components) and robust feature set streamline hotel operations while improving the guest experience.

---

## ✨ Features

- 🔐 **Secure Login** – Role-based access control for Admin and Receptionist
- 🏨 **Room Management** – Add, update, delete rooms and track availability
- 📅 **Reservations** – Handle bookings with check-in/check-out tracking
- 👤 **Guest Profiles** – Maintain guest information and reservation history
- 💳 **Billing System** – Generate invoices and calculate total stay costs
- 📊 **Reports** – View booking history, revenue, and analytics
- 🎨 **Modern UI** – Sleek and user-friendly design using Guna UI2

---

## ⚙️ Installation

### Prerequisites

- Windows OS
- Visual Studio (2019 or later recommended)
- .NET Framework 4.7.2 or higher
- SQL Server (Express or higher)
- [Guna.UI2.WinForms](https://www.nuget.org/packages/Guna.UI2.WinForms) (via NuGet)

### Steps

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/mohammedbourass-youssef/Rif-Hotel-Management-System.git


2. **Open the Project:**
   - Open the `.sln` file in Visual Studio.
   - Restore NuGet packages when prompted.

3. **Create the Database:**
   - Open SQL Server Management Studio (SSMS).
   - Create a new database (e.g., `HotelDB`).
   - Run the SQL script (if available) to create tables and insert seed data.

4. **Update Connection String:**
   In `App.config`, update the connection string to match your SQL Server setup:
   ```xml
   <connectionStrings>
       <add name="constr" connectionString="Data Source=.;Initial Catalog=HotelDB;Integrated Security=True" />
   </connectionStrings>
   ```

5. **Run the Project:**
   - Build the solution and press `F5` or click `Start` to run the application.

---

## 🛠️ Configuration

- Ensure **SQL Server** is installed and running.
- Confirm that the **database name** and **connection string** in `App.config` are correct.
- Install **Guna.UI2.WinForms** via NuGet if not already installed.

---

## 🚀 Usage

1. Launch the application.
2. Log in using existing Admin or Receptionist credentials.
3. Use the left-side menu to manage:
   - 🛏️ Rooms
   - 📘 Reservations
   - 👤 Guests
   - 💵 Billing
   - 📈 Reports
4. Admin users can create and manage staff accounts.

---

## 🤝 Contributing

Contributions are welcome! To contribute:

1. **Fork** the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/YourFeatureName
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add Your Feature"
   ```
4. Push your branch:
   ```bash
   git push origin feature/YourFeatureName
   ```
5. Open a **Pull Request** and describe your changes clearly.

---

## 📄 License

This project is licensed under the **MIT License**. You are free to use, modify, and distribute it.

---

## 📬 Contact

**Developer:** Mohammed Bourass Youssef  
📧 **Email:** your-email@example.com  
🌐 **GitHub:** [mohammedbourass-youssef](https://github.com/mohammedbourass-youssef)

---
