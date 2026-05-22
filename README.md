# Secure Password Generator (C#)

## 🎯 Project Objective
To create a command-line interface (CLI) tool that generates secure, customizable passwords. Unlike basic tutorial password generators, this project focuses on real cybersecurity standards: memory efficiency, cryptographically secure pseudo-random number generation (CSPRNG), and mathematical password strength (entropy) calculation.

## 🛠 Technology & Skills Matrix

| Stage | Core Technology / Class | Skill Developed |
| :--- | :--- | :--- |
| **Stage 1** | Basic C# Syntax | Console I/O, loops, basic logic |
| **Stage 2** | `StringBuilder` | Efficient memory management, conditionals |
| **Stage 3** | `System.Security.Cryptography` | CSPRNG, ensuring cryptographic security |
| **Stage 4** | `Math.Log2` | Security theory (mathematical entropy) |

---

## 🗺️ Development Stages

### Stage 1: Basic Generation (✅ Done)
- **Goal:** Create the application skeleton and generate a basic random string of characters.
- **Required Knowledge:** Variable declaration, `Console.ReadLine()`, `for` loops, `System.Random`.
- **Tasks:**
  - [x] Prompt the user to enter the desired password length.
  - [x] Generate a random string from a basic alphabet array.
  - [x] Output the result to the console.
- **Validation Criteria:** Entering the number "10" outputs a random 10-character string.
- **Common Mistakes:** Application crashes if the user enters a letter instead of a number for the length.
- **Definition of Done:** Code compiles successfully and generates random text of the requested length.

---

### Stage 2: Character Filter Management (Current Step)
- **Goal:** Allow the user to select which character types to include and optimize how the string is built in memory.
- **Required Knowledge:** `if/else` statements, string concatenation, `StringBuilder` class.
- **Tasks:**
  - [x] Create 4 base strings: lowercase, uppercase, numbers, special characters.
  - [ ] Prompt the user (Yes/No) to include each category.
  - [ ] Combine the selected categories into a single "character pool" string based on user input.
  - [ ] Update the generation logic to use `StringBuilder` instead of basic string concatenation (`+=`).
- **Validation Criteria:** If only numbers are selected with a length of 5, the program must output exactly 5 digits (e.g., "54821").
- **Common Mistakes:** Allowing all options to be rejected (if the user selects "No" for everything, the program tries to generate from an empty string and crashes).
- **Definition of Done:** The user can interactively toggle character groups, and the application uses `StringBuilder` for output generation.

---

### Stage 3: Cryptographic Security (CSPRNG)
- **Goal:** Replace the standard pseudo-random number generator with a cryptographically secure one, making the passwords resistant to prediction attacks.
- **Required Knowledge:** Working with external .NET classes, `RandomNumberGenerator` from the `System.Security.Cryptography` namespace.
- **Tasks:**
  - [ ] Remove all code utilizing `new Random()`.
  - [ ] Import the `System.Security.Cryptography` namespace.
  - [ ] Use `RandomNumberGenerator.GetInt32(0, pool.Length)` to securely pull a random character from the pool.
- **Validation Criteria:** The program works exactly like Stage 2, but utilizes CSPRNG under the hood.
- **Common Mistakes:** Confusing the older `RandomNumberGenerator.Create()` method with the newer static `.GetInt32()` method (C# 10+ recommends the static approach).
- **Definition of Done:** There are no traces of the `System.Random` class left in the codebase.

---

### Stage 4: Entropy (Strength) Calculation
- **Goal:** Display the mathematical strength (in bits) of the generated password to the user.
- **Required Knowledge:** Basic cybersecurity theory (Shannon Entropy), utilizing mathematical operations (`Math.Log2`).
- **Tasks:**
  - [ ] Calculate the length of the character "pool" (R).
  - [ ] Given the password length (L), apply the formula: `Entropy = L * Math.Log2(R)`.
  - [ ] Display the resulting entropy value below the generated password.
- **Validation Criteria:** If the pool has 62 characters (letters + numbers) and the length is 12, the entropy should display as ~71 bits.
- **Common Mistakes:** Mixing up the pool length (R) with the password length (L) in the formula.
- **Definition of Done:** The mathematical strength in bits is displayed after every generated password.

---

## 🚀 How to Run the Project
1. Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.
2. Clone the repository:
   
```bash
   git clone [https://github.com/YOUR_NAME/secure-password-generator.git](https://github.com/YOUR_NAME/secure-password-generator.git)
