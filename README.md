# Vendstor

🚧 🚧 This repository has been relocated to https://github.com/vendstor/vendstor 🚧 🚧

Vendstor is the most advanced C# open sourced Point Of Sale App for Windows. It enables you to sell, manage employees, inventory and monitor your sales.

## ✨ Features

-   Create, Manage & Delete Stores
-   Create, Manage & Delete Users (Employee Accounts)
-   Assign Roles to Users (Employee Accounts)
-   Create, Manage & Delete Products
-   Create, Manage & Delete Product Suppliers
-   Create, Manage & Delete Product Tags
-   Create, Manage & Delete Product Categories
-   Create, Manage & Delete Product Discounts
-   Create, Manage & Delete Product Brands
-   Create, Manage & Delete Payment Methods
-   Create, Manage & Delete Customers
-   Create, Manage & Delete Customer Groups
-   Create, Manage & Delete Orders
-   Create, Manage & Delete, Apply Taxes
-   Monitor Product Inventories
-   Scan items with App
-   Create Products from App
-   Create Discounts at checkout
-   Track each sale
-   Print custom Product Labels
-   Translate in any language
-   Print Receipts
-   Customize Receipts template
-   Customize Design
-   Refund sales
-   Manage Sales
-   Monitor Sales Reports
-   Monitor Inventory Reports
-   Monitor Discount Reports
-   Monitor each User Sales
-   ... and tons of features

## ℹ️ About

I created Vendstor back in 2018, when I [(Franz)](https://github.com/franznkemaka) was 15 years old. I just finished learning C# and had so much fun working on the project. I wanted to create something new and useful and I knew someone having a retail store with a lot of difficulties to manage their store, so I spoke with the owner about the advantages of having a modern POS. Finally, I decided to develop something unique for their Business.
After a couple of months, it turned out there won't be able to use the System due to some legal limitations. Over time, I was thinking of building something similar for other businesses. But It was kind of complicated to use a PC since Tablet POS are easier to work with. That's why I decided to develop a completely new system. Unfortunately, the store for which I built this POS never used it.

## ✨ Purpose & Future

To valorize the time, energy and the love I put into it, I decided to open-sourced it and make it available to everyone. You can clone it modify it for your own store or even develop a system with it.

I'm just cleaned the code a little bit. It is now live. I might even have to redesign the Database.

### 🚧 Note

It is very important to note the design pattern of this project before interacting with. It was designed to host a MySQL Client and connect directly to the server which turns out isn't a good practice, as the MySQL database connection info can be de-obfuscated. Please check out the RoadMap at bottom to see what has to be done to remove this anti-pattern.

## 📦 Applications

-   `Vendstor` is the main application, the POS itself

-   `Installer` is a software used to query the backend to install a particular version of the main app. It is used in case of a managed software where it releases are centralized.

-   `MiniInstaller` is a software that installs the `Installer`, this is for fast distribution purpose

-   `Shell` is a CLI installed in the user host machine, it installs Vendstor, uninstalls it, or updates it.

-   `Uninstaller` is a software that orders the `Shell` to remove all Vendstor instances from the host machine.

## 🎉 Getting started

Vendstor is a C# WinForm application that requires the following services in order to work correctly.

-   MySQL Database: to store data
-   FTP Server: to upload user content

### Running Application

1. Clone repository locally

2. Open in Visual Studio

3. Install all required packages

4. Setup the database by following the guide below

5. Setup FTP Server to allow Image upload (follow the guide below)

6. Run the application and it should just work.

### More

The Vendstor windows application can also communicate with a React Native client app. For the moment it is not yet released, on my spare time I will release it as well and explain how to connect both.

## 🗃 Database

You either use a local MySQL Database or a production one. Here is how you can set up the Vendstor Database.

-   Create a new database called **Vendstor**

-   Import the SQL file `vendstor.sql` and migrate it to create the different tables and columns

## 📸 FTP Server (for image upload)

If you are using a Linux server, then the setup is very easy. Create a new FTP user on your server and grant it a read and write access to a specific folder that you can specify in the constants file before building your application.

If you are on the localhost, consider using Xampp FTP server, then follow the same guide as specified in the Linux Server configuration.

## 📌 Roadmap

-   [ ] 🚀 Release Vendstor 2018
-   [ ] 🖥️ Add Windows support
-   [ ] ⚡️ Improve code base
-   [ ] 🗃 Add SQLite database support
-   [ ] 🏗 Add local image upload support
-   [ ] 🏗 Opt-in feature to either use local SQLite or use custom MySQL
-   [ ] 🏗 Opt-in feature to either use local image upload or use custom FTP server
-   [ ] 🚀 Release standalone version (serverless requirement and production ready)
-   [ ] 🏗 Add REST API integration for both data-management and image upload
-   [ ] 🚀 Release standalone version with custom REST API backend

## 🤝 Authors

-   [@franznkemaka](https://github.com/franznkemaka) (back in 2018)

## ❤️ Contributing

This project is currently in standby mode. Check out the todo/roadmap to see what you can help with. Any contribution of any kind is welcome.

## ⚖️ License

This project is licensed under the [MIT](LICENSE) License.
Do what ever you want with.

Please contact me for any commercial purposes.

---

                  Vendstor™

        Written by : Franz Nkemaka
                Date : 2018
        Last Modified: 2020 (to release)
           Copyright : © 2020 Franz Nkemaka

            Made With ❤️ By Franz Nkemaka

---
