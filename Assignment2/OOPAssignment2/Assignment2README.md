# Employee Payroll Processing System (C#)

This project is a rewrite of a previous Object-Oriented Programming assignment originally completed in C++. The assignment was recreated in C# to strengthen understanding of C# syntax, object-oriented design, inheritance, file handling, and input validation.

## Overview

This program reads employee payroll information from an input file, validates the data, calculates gross pay (including overtime pay), and writes results to output files.

The system demonstrates:

- Object-oriented programming concepts
- Inheritance
- Encapsulation using private data members and public methods
- File input/output
- Input validation
- Basic payroll calculations

---

# Features

## Employee Processing

Each employee record contains:

- First name
- Last name
- Hourly pay rate
- Hours worked

The program:

1. Reads employee data from a text file
2. Validates all input data
3. Stores the information in Employee objects
4. Calculates gross pay
5. Outputs valid records
6. Sends invalid records to an error file

---

# Object-Oriented Design

## `People` Class

Base class containing:

- First name
- Last name
- Error status

Methods include:

- Setters and getters
- Name validation
- Error handling

---

## `Employee` Class

Derived from `People`.

Additional employee-specific data includes:

- Hourly rate
- Hours worked
- Gross pay

Methods include:

- Gross pay calculation
- Overtime calculation
- Employee display/output functions

---

# Overtime Calculation

Employees working over 40 hours receive overtime pay at:

```text
1.5 × hourly rate
```

Formula used:

```text
(40 × rate) + ((hours - 40) × rate × 1.5)
```

---

# File Handling

The program uses:

- `StreamReader`
- `StreamWriter`
- `File.Exists()`

Features include:

- User-selected input file
- User-selected output file
- Automatic error file generation
- File existence checking
- Output overwrite protection

---

# Input Validation

The program validates:

## Names

- Cannot be blank
- Cannot contain spaces

## Hourly Rate

- Must contain only numeric characters and a decimal point
- Must contain exactly one decimal point
- Must be at least `$8.25`

## Hours Worked

- Must contain only numeric characters and a decimal point
- Must contain exactly one decimal point
- Cannot be negative

---

# Example Input File

```text
John
Smith
15.50
40.0
Jane
Doe
22.75
45.5
Mike
Johnson
10.25
38.0
```

---

# Example Output

```text
Smith, John: $620.00
Doe, Jane: $1080.63
Johnson, Mike: $389.50
```

---

# Error Handling

Invalid employee records are flagged and written to an error file instead of being processed normally.

Examples of invalid data:

- Missing names
- Spaces in names
- Invalid pay rates
- Negative hours worked
- Non-numeric values

---

# Technologies Used

- C#
- .NET
- Visual Studio

---

# Educational Goals

This assignment was designed to practice:

- C# class design
- Inheritance
- File processing
- Input validation
- Console applications
- Translating logic from C++ into C#

---

# Author

John Gerega  
Computer Science Graduate — Pennsylvania Western University
