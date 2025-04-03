# HtmlScrape

**HtmlScrape** is a C# console application designed to scrape HTML content, extract specific data (e.g., names of media outlets), populate a `MediaOutlets` class, and save the extracted data into an SQLite database.

---

## Features

- Download HTML content from a specified URL.
- Extract values of media outlet names using the HtmlAgilityPack library.
- Populate the extracted data into a `MediaOutlets` class.
- Save the media outlets' information into an SQLite database for persistent storage.
- Display saved data from the SQLite database in the console.

---

## Requirements

- **.NET 8**
- **HtmlAgilityPack** (NuGet package for HTML parsing)
- **SQLite** (Embedded database for data storage)

---

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/jason-cobb/HtmlScrape.git
2. Run the program.
3. Console will printout the database, display the media outlets that have logos displayed, it will then print the database again with the added values from the new run.
