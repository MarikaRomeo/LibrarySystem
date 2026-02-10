# Library System – Console Application (C#)

Detta projekt är ett konsolbaserat bibliotekssystem skrivet i C# och .NET.
Syftet är att demonstrera grundläggande objektorienterade principer enligt kursplanen.

---

## Funktionalitet

Systemet hanterar:

- Böcker (Book)
- Medlemmar (Member)
- Utlåning (Loan)

Användaren kan:

- Söka efter böcker (titel, författare, ISBN)
- Låna och returnera böcker
- Visa statistik över biblioteket
- Sortera böcker efter titel eller utgivningsår

---

## Objektorienterade principer

Projektet demonstrerar följande OOP-koncept:

### Klasser och objekt
Varje domänobjekt representeras av en egen klass (Book, Member, Loan).

### Inkapsling
- Properties använder korrekta åtkomstnivåer
- ISBN kan endast sättas vid skapande av Book
- Interna listor skyddas via privata fält och readonly-access

### Komposition
Klassen `Library` innehåller och hanterar:
- Samling av böcker
- Samling av medlemmar
- Samling av lån

### Interface och polymorfism
Interface `ISearchable` används för enhetlig sökfunktionalitet.
Alla sökbara objekt implementerar metoden `Matches`.

### Algoritmer
- Sökning med LINQ
- Sortering av böcker
- Statistik:
  - Totalt antal böcker
  - Antal utlånade böcker
  - Mest aktiv låntagare

---

## Tester

Projektet innehåller ett separat testprojekt med xUnit.

### Täckta tester:
- Book: konstruktor, tillgänglighet, formatering
- Loan: förfallodatum, återlämning
- ISearchable: sökning (case-insensitive)
- Statistik och algoritmer

Totalt antal tester: **10**

---

## Hur man kör projektet

### Köra applikationen
1. Öppna solution i Visual Studio
2. Sätt `LibrarySystem` som Startup Project
3. Kör med **Start ▶**

### Köra tester
Via Visual Studio:
- Test → Run All Tests

Via terminal:
```bash
dotnet test
