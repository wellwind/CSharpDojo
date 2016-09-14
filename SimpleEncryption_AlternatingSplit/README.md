Simple Encryption #1 - Alternating Split
==========

For building the encrypted string:

Take every 2nd char from the string. Then the other chars.

Do this n times!

Examples:

```
"This is a test!", 1 -> "hsi  etTi sats!"
"This is a test!", 2 -> "hsi  etTi sats!" -> "s eT ashi tist!"
```

Write two methods:
```
string Encrypt(string text, int n)
string Decrypt(string encryptedText, int n)
```
For both methods:
- If the input-string is null or empty return exactly this value!
- If n is <= 0 then return the input text.

https://www.codewars.com/kata/57814d79a56c88e3e0000786
