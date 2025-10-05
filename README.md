# 🍕 PizzLicious — Simple Pizza Ordering System | C# Desktop App 💻🔥

> 🚀 *"WHERE EVERY SLICE TELLS A STORY"* — Because every pizza deserves to be perfect!

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D7?style=for-the-badge&logo=windows&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

---

## 🌟 Project Overview

**PizzLicious** is a sleek, fully functional **C# Desktop Application** built with **Windows Forms**, designed to simulate a real-world pizza ordering experience 🍕.  
Users can select pizza size, crust type, toppings, and dining option — then instantly calculate the total price and **save the order to a text file** with timestamp for permanent record keeping 📂✅.

🎯 Perfect for academic projects, portfolio showcases, or as a foundation for a real restaurant system!

---

## 🎁 Key Features

| Feature                  | Description                                                                 |
|--------------------------|-----------------------------------------------------------------------------|
| 🖱️ Intuitive GUI         | Clean, user-friendly interface built with Windows Forms                     |
| 🧮 Auto Price Calculator | Dynamically calculates total price based on user selections                 |
| 💾 Order Persistence     | Saves every order to a `.txt` file (e.g., `orders.txt` or date-based)       |
| 📅 Timestamp Logging     | Each order is stamped with exact date & time (e.g., `2025-09-22 18:12:12`)  |
| 📋 Professional Formatting | Orders saved with clear headers, separators, and itemized pricing          |
| ⚙️ Scalable Architecture | Easy to extend: add database, printing, users, discounts, etc.              |

---

## 🖼️ Application Screens (Based on Your Screenshots)
---

# 1. 🎬 Welcome Screen


- Elegant black & gold theme 🖤💛
- Mouth-watering pizza image 🍕
- Bold header:  
  > **PIZZA RESTO — PizzLicious**

<img width="1532" height="902" alt="Screenshot 2025-09-25 144449" src="https://github.com/user-attachments/assets/3679d872-3a95-44d6-8a9d-62565ee864ba" />

---

# 2. ℹ️  About As
<img width="1549" height="912" alt="Screenshot 2025-09-25 144458" src="https://github.com/user-attachments/assets/d0aed858-4af0-47da-bdfe-84fe5813f49b" />

---

# 3. 💡 Tabel Manu 

<img width="1539" height="916" alt="Screenshot 2025-09-25 144508" src="https://github.com/user-attachments/assets/dd5ce7fc-0471-4887-a6ec-5afd0b9da8eb" />

---

# 4. 📢 Main Screen PizzLicious 

<img width="1549" height="925" alt="Screenshot 2025-09-25 144516" src="https://github.com/user-attachments/assets/7ca6e095-6645-404f-a06c-2f0547bc0a91" />

<img width="1550" height="922" alt="Screenshot 2025-09-25 144532" src="https://github.com/user-attachments/assets/70968531-9bc0-4790-932c-495029a5f166" />

<img width="1546" height="921" alt="Screenshot 2025-09-25 144542" src="https://github.com/user-attachments/assets/4248f97c-cd7b-4dad-98d1-5e439a059b9f" />

---

# 5. 📜 Create Order 

<img width="1546" height="959" alt="Screenshot 2025-09-25 144559" src="https://github.com/user-attachments/assets/7a83041b-bda0-4bc5-b6ee-4cce15590bfa" />

<img width="1538" height="930" alt="Screenshot 2025-10-05 132838" src="https://github.com/user-attachments/assets/cb628ec4-f9af-47cb-a81f-14f4bfcb074a" />


---

# 6. 📄🗂️ Save Order in the File `DataRestoShadweOrders`

<img width="1538" height="930" alt="Screenshot 2025-10-05 132838" src="https://github.com/user-attachments/assets/8cfae6d3-b090-4325-9227-a76e7eda507c" />

<img width="1919" height="1079" alt="Screenshot 2025-10-05 134121" src="https://github.com/user-attachments/assets/a92ab577-f024-42b0-9eb0-d3a423da48a2" />

---


# 7.📜 Another Create Order 

<img width="1558" height="965" alt="Screenshot 2025-09-25 144639" src="https://github.com/user-attachments/assets/8b7133aa-def1-49f9-a032-6b61ef78e8d0" />

<img width="1919" height="1079" alt="Screenshot 2025-10-05 134231" src="https://github.com/user-attachments/assets/77f5c019-07d2-4176-846d-a36369228469" />


---


## 2. 🛒 Order Form

Includes:

- **📏 Pizza Size** (ComboBox):  
  `Small ($5)` — `Medium ($10)` — `Large ($15)`

- **🍞 Crust Type** (RadioButtons or ComboBox):  
  `Thin Crust ($5)` — `Thick Crust ($10)`

- **🧄 Toppings** (Checkboxes):  
  `Mushrooms (+$8)` — `Olives (+$5)` — `Extra Cheese (+$5)` — `Onion (+$2)` — `Green Peppers (+$4)` —  `Tomatoes (+$2)`

- **📍 Dine Option** (RadioButtons):  
  `Eat In` — `Take Away`

- **🧮 “Calculate Total” Button** → Displays price in Label or TextBox

- **✅ “Place Order” Button** → Saves order to file + shows confirmation

---

## 💾 Order Saving System — How It Works

When user clicks “Place Order”:

1. Creates a `PizzaOrder` object with all selections 🧾
2. Uses `StreamWriter` to append order to text file 📄
3. Automatically adds current timestamp ⏰
4. Inserts visual separators for readability 📏
5. Shows success message 🎊



---

## 🛠️ Technologies & Tools Used

| Component               | Technology / Tool                     |
|-------------------------|---------------------------------------|
| 💻 Programming Language | C# (.NET Framework )                  |
| 🖼️ UI Framework         | Windows Forms                         |
| 🧩 Controls             | Button, ComboBox, CheckBox, Label     |
| 🕒 Date & Time          | `DateTime.Now.ToString()`             |
| 🧪 IDE                  | Visual Studio 2022                    |

---



## 🚀 Future Roadmap — What’s Next? 🗺️

- [ ] ➕ Add database support (SQLite or SQL Server) 🗄️
- [ ] 📑 View past orders screen (DataGridView)
- [ ] 🖨️ Print receipts directly to printer
- [ ] 👤 Staff login system
- [ ] 🎫 Discount coupons & seasonal offers
- [ ] 📤 Export orders to PDF or Excel
- [ ] 🌐 Web version (ASP.NET Core) — next challenge! 🚀

---

## 🧑‍💻 Why This Project Stands Out

- ✅ Covers core C# concepts: OOP, GUI, File I/O
- ✅ Practical and production-ready feel
- ✅ Easy to extend and customize
- ✅ Looks and feels professional when presented 👔

---

## 📌 How to Setup & Run

1. ⬇️ Clone or download the project:
   ```bash
   git clone https://github.com/yourusername/PizzLicious.git
   ```
2. 🧩 Open the .sln file in Visual Studio
   
3. ▶️ Press F5 or click “Start” to run the app
   
4. 🍕 Place an order and test the system!

--- 

# 👨💻 Author

**Ahmed Jehad Ahmed**  


🔗 [GitHub Profile](https://github.com/7mee3d)

📧 [Email Contact](mailto:enginnerahemdjehad2004@gmail.com)
