# 🏦 Banking System Project – Practical Application After Learning Courses

This project is the result of my practical implementation after completing **Courses 14, 15, and 18**.  
It represents a **Bank Management System** built using **C# WinForms, SQL Server, and 3-Tier Architecture**.

---

## 📖 My Learning Journey

🔹 At the beginning, I asked **ChatGPT** about the best color theme for a banking application. It suggested **dark blue, gold, and gray**. However, I didn’t like the gray, so I replaced it with **white**.  

🔹 After that, I analyzed the **ERD** and designed the **database schema**. Later, I realized that one table and one column were not actually needed during programming, which was an important lesson in database optimization.  

💡 I used **DataTable** as the main data structure for handling data coming from SQL Server. At first, I didn’t know how to perform a **join between two tables** with a DataTable, but then I discovered that it can be done using **LINQ**.  

🐞 One of the most valuable lessons I learned is to **never underestimate debugging**. At some point, I forgot to use it and wasted a lot of time searching for an error. Once I remembered to debug, I found the issue immediately. Debugging can save an incredible amount of time and effort!  

📽️ In the demo video, I accidentally forgot to record the part about deleting users and clients 😅. Overall, the project took me about **one week** of work.  

🎨 The design inspiration came from **@Saleem_Kassab**, but I customized it in my own way.  

---

## 🚀 Banking Management System – Functional Requirements Overview

### 🔐 1. Login Page
- Secure user authentication.  
- Input fields: **Username & Password**.  
- Account lock after **3 failed attempts**.  

---

### 🏠 2. Home Dashboard
A centralized interface to manage **clients, users, transactions, and currency exchange**.

---

### 👥 Client Management
- **View Clients**: Search, sort (ASC/DESC), and manage accounts (Deposit, Withdraw, Transfer, Delete).  
- **Add Client**: Account number, PIN, personal info, and balance fields with confirmation and auto-clear.  
- **Update Client**: Modify existing client details with confirmation and auto-clear.  

---

### 💸 Client Transactions
- **Deposit & Withdraw**:  
  - Real-time balance display.  
  - Validations with success/confirmation messages.  
  - Smart handling when balance becomes zero.  

- **Transfer**:  
  - Transfer funds between accounts with balance validation.  
  - Show balances for both accounts.  
  - Confirmation and error messages.  

- **Transfer Log**:  
  - Track all transactions with search functionality.  

- **Total Balance**:  
  - Display total balance in both numbers and words.  

---

### 👤 User Management
- **View Users**: List with search, sort, and delete options.  
- **Add/Update Users**:  
  - Username, personal details, and secured password.  
  - Permission system with checkboxes (Manage Clients, Transactions, Users, Currency Exchange).  
  - Option for **full access** using radio button.  
  - Confirmation and auto-clear functionality.  

---

### 🧾 Login Register
- Track login history with search and sort.  

---

### 💱 Currency Exchange
- **Show Currencies**: Searchable by code or country.  
- **Update Rate**:  
  - Update exchange rate with confirmation and success messages.  
- **Currency Calculator**:  
  - Convert between currencies with real-time conversion results.  

---

## 🛠️ Tech Stack
- **Language**: C# (WinForms)  
- **Database**: SQL Server  
- **Architecture**: 3-Tier Architecture

---
