🧪 How to Test the Project
To ensure the application handles edge cases gracefully, perform the following tests:

Extreme Lengths: Try entering lengths like 0, -5, or extremely large numbers (e.g., 100000). The program should reject invalid numbers and prompt again.

Invalid Input: When asked for length, enter letters (e.g., abc). The program should handle the exception gracefully (using int.TryParse).

All Filters Off: Answer "No" to all character prompts. The program should display an error stating that at least one character set must be selected.


🏁 Final Result Example
=== Secure Password Generator ===
Enter password length: 16
Include uppercase letters? (y/n): y
Include lowercase letters? (y/n): y
Include numbers? (y/n): y
Include special characters? (y/n): y

Generated Password:  k#9vP2$mLq!7Rw&B
Password Entropy:    104 bits (Strong)
=================================
