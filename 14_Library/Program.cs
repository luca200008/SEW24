// See https://aka.ms/new-console-template for more information

using _14_Library;
using _20_Libary;

Liabary buchAustellungWeihnachten2024 = new Liabary();
Book bookAhorner = new Book("Peer Ahornern", "Handbuch der östtereischischen Schimpfwörter", 120);
Book bookBrückelmeier = new Book("Jan Brückelmeier", "Bier braun", 521);
Book bookRhue = new Book("Morton Rhue", "Die Welle", 1020);
Book bookHesse = new Book("Christian Hesse", "Von Zahlen, Menschen und Maschinen", 220);


buchAustellungWeihnachten2024.PrintBookList();

buchAustellungWeihnachten2024.BorrowBook(bookAhorner);
buchAustellungWeihnachten2024.BorrowBook(bookRhue);

buchAustellungWeihnachten2024.PrintAvailableList();