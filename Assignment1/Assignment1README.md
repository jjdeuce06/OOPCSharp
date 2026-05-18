# Water Utility Billing System (C#)

This project is a rewrite of a previous Object-Oriented Programming assignment originally completed in C++. The assignment was recreated in C# to strengthen understanding of C# syntax, object-oriented programming concepts, inheritance, file handling, validation, and console application development.

## Overview

This program reads customer water meter information from an input file, validates the data, calculates utility bills, and writes results to output files.

The program demonstrates:

- Object-oriented programming
- Encapsulation
- File input/output
- Input validation
- Error handling
- Console-based user interaction
- Data processing using classes and methods

---

# Features

## Customer Processing

Each customer record contains:

- First name
- Last name
- Old meter reading
- New meter reading

The program:

1. Reads customer information from an input file
2. Validates all input data
3. Stores data in Customer objects
4. Calculates water utility bills
5. Writes valid records to an output file
6. Sends invalid records to an error file

---

# Object-Oriented Design

## `Customer` Class

The `Customer` class stores and processes all customer data.

### Private Data Members

- First name
- Last name
- Old meter reading
- New meter reading
- Error status

### Methods Include

- Setters and getters
- Validation methods
- Bill calculation
- Customer display functions
- Destructor for object cleanup demonstration

---

# Billing Logic

The utility bill is calculated using:

```text
(New Meter - Old Meter) × 0.20
```

If the meter rolls over past 9999, rollover logic is used:

```text
((10000 - oldmeter) + newmeter) × 0.20
```

This simulates real-world utility meter rollover behavior.

---

# File Handling

The program uses:

- `StreamReader`
- `StreamWriter`
- `File.Exists()`

Features include:

- User-selected input files
- User-selected output files
- Automatic error file generation
- File validation
- Output overwrite protection

---

# Input Validation

The program validates:

## Names

- Cannot be blank

## Meter Readings

- Must be numeric
- Must be between `0` and `9999`

Invalid records are flagged and written to an error file.

---

# Example Input File

```text
John Smith 1200 1450
Jane Doe 9800 150
Mike Johnson 5000 5400
```

---

# Example Output File

```text
Smith, John 50.00
Doe, Jane 70.00
Johnson, Mike 80.00
```

---

# Error Handling

Records containing invalid data are written to:

```text
error.txt
```

Examples of invalid data:

- Missing names
- Non-numeric meter readings
- Negative readings
- Readings greater than 9999

---

# Technologies Used

- C#
- .NET
- Visual Studio

---

# Educational Goals

This assignment was designed to practice:

- C# class design
- File processing
- Validation techniques
- Console applications
- Translating logic from C++ into C#
- Object-oriented programming principles

---

# Author

John Gerega  
Computer Science Graduate — Pennsylvania Western University
