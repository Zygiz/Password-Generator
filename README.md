# Secure Password Generator

A lightweight, cryptographically secure command-line password generator built in C#. This project was created to practice secure coding fundamentals, memory efficiency, and password strength analysis.

## Features
- **Cryptographically Secure:** Uses `.NET` `RandomNumberGenerator` (CSPRNG) instead of standard pseudo-random generators.
- **Customizable Criteria:** Toggle uppercase letters, lowercase letters, numbers, and special characters.
- **Strength Evaluation:** Calculates and displays password entropy (in bits) to measure mathematical strength.
- **Memory Optimized:** Utilizes `StringBuilder` for efficient string manipulation.

## How It Works
Unlike standard `System.Random`, which is predictable and unsafe for security purposes, this tool leverages OS-level entropy to generate truly unpredictable sequences, making it resistant to pre-computation or seed-guessing attacks.

Entropy is calculated using the formula:  
*E = L * log2(R)*  
where **L** is password length and **R** is the size of the character pool.

## Screenshots


## How To Run
1. Ensure you have the .NET SDK installed.
2. Clone the repository:
   ```bash
   git clone [https://github.com/TAVO_VARDAS/secure-password-generator.git](https://github.com/TAVO_VARDAS/secure-password-generator.git)

dotnet run


## Lessons Learned
- Understanding the critical difference between PRNG (`System.Random`) and CSPRNG (`RandomNumberGenerator`).
- Implementing mathematical concepts like Shannon Entropy into functional code.
- Basic input validation to prevent application crashes from invalid user inputs.
