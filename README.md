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

### 1. 🎬 Welcome Screen

- Elegant black & gold theme 🖤💛
- Mouth-watering pizza image 🍕
- Bold header:  
  > **PIZZA RESTO — PizzLicious**
- Button: **“Start Your Order!”** ⏩

---

### 2. 🛒 Order Form

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
