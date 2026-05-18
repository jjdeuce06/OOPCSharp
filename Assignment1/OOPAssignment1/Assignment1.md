# OOP Assignment 1 – Customer Water Bill Processing System

## Overview
This program is a C# console application designed to process customer water meter readings from an input text file and generate billing information. The application demonstrates core Object-Oriented Programming concepts along with file handling and data validation techniques.

The program reads customer data line-by-line from a user-provided input file, calculates each customer’s bill based on meter readings, and writes valid billing information to an output file. Invalid records are written to a separate error file.

---

# Features

- Reads customer records from an input text file
- Validates customer information and meter readings
- Calculates customer utility bills
- Supports rollover meter calculations
- Writes valid bills to an output file
- Writes invalid records to an error file
- Prevents invalid file handling through existence checks
- Uses append and overwrite logic for output files
- Displays billing information to the console

---

# Object-Oriented Programming Concepts Used

## Classes and Objects
The program uses a `Customer` class to represent each customer record.

Example:

```csharp
Customer customer = new Customer();
```

Each customer object stores:
- First name
- Last name
- Old meter reading
- New meter reading
- Error status

---

## Encapsulation
All customer data members are declared as private and accessed through public methods.

Example:

```csharp
private string fname;
private float oldmeter;
```

Setter methods validate input before assigning values.

---

## Constructors
The `Customer` constructor initializes default values for all data members.

```csharp
public Customer()
{
    oldmeter = 0;
    newmeter = 0;
    error = 0;
}
```

---

## Methods
The program uses multiple methods to:
- Set customer information
- Validate data
- Calculate bills
- Display customer information
- Retrieve error status

Examples:
- `Setfname()`
- `Setoldmeter()`
- `GetBill()`
- `DisplayBill()`

---

## Destructor
A destructor is included to demonstrate object cleanup.

```csharp
~Customer()
{
    Console.WriteLine($"Destructor called for Customer: Name={fname} {lname}");
}
```

---

# File Handling

## Input File Processing
The program uses `StreamReader` to read customer records from a text file.

```csharp
using (StreamReader reader = new StreamReader(inputfileName))
```

Each line is split into customer data fields:
- First Name
- Last Name
- Old Meter Reading
- New Meter Reading

---

## Output File Processing
Valid customer billing information is written to an output file using `StreamWriter`.

```csharp
using (StreamWriter writer = new StreamWriter(outputfileName, true))
```

---

## Error File Processing
Invalid records are written to `error.txt`.

Examples of invalid data:
- Negative meter readings
- Meter readings greater than 9999
- Non-numeric meter readings
- Missing data

---

## File Validation
The program checks:
- If the input file exists
- If the output file already exists
- Whether the user wants to overwrite an existing output file

Example:

```csharp
File.Exists(outputfileName)
```

---

# Billing Logic

## Standard Billing
If the new meter reading is greater than or equal to the old reading:

```text
Bill = (newmeter - oldmeter) × 0.20
```

---

## Meter Rollover Billing
If the meter rolls over past 9999:

```text
Bill = ((10000 - oldmeter) + newmeter) × 0.20
```

---

# Example Input File

```text
John Doe 9500 200
Sarah Connor 1000 1500
Tony Stark -1 500
Bruce Wayne abc 400
```

---

# Example Output File

```text
Doe, John 140.0
Connor, Sarah 100.0
```

---

# Example Error File

```text
Tony
Stark
-1
500

Bruce
Wayne
abc
400
```

---

# Technologies Used

- C#
- .NET Console Application
- StreamReader
- StreamWriter
- Object-Oriented Programming Principles

---

# Learning Outcomes

This assignment demonstrates:
- Object-oriented design
- Encapsulation and class structure
- File input/output handling
- Data validation
- Exception prevention
- String parsing
- Console application development in C#
