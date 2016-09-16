Simple Encryption #2 - Index-Difference
===============

For encrypting strings this region of chars is given (in this order!):

- all letters (ascending, first all UpperCase, then all LowerCase)
- all digits (ascending)
- the following chars: ".,:;-?!'()$%&"and the'"'-char

These are 77 chars! (This region is zero-based.)

Write two methods: 

```
string Encrypt(string text)
string Decrypt(string encryptedText)
```

Prechecks:

1. If the input-string has chars, that are not in the region, throw an Exception(C#, Python) or Error(JavaScript).
2. If the input-string is null or empty return exactly this value!

For building the encrypted string:

1. For every second char do a switch of the case.
2. For every char take the index from the region. Take the difference from the region-index of the char before (from the input text! Not from the fresh encrypted char before!). (Char2 = Char1-Char2)
Replace the original char by the char of the difference-value from the region. In this step the first letter of the text is unchanged.
3. Replace the first char by the mirror in the given region. ('A' -> '"', 'B' -> '&', ...)

Simple example:

- Input: ``` "Business" ```
- Step 1: ``` "BUsInEsS" ```
- Step 2: ``` "B61kujla" ```
    - ``` B -> U ```
        - ``` B (1) - U (20) = -19 ```
        - ``` -19 + 77 = 58 ```
        - ``` Region[58] = "6" ```
    - ``` U -> s ```
        - ``` U (20) - s (44) = -24 ```
        - ``` -24 + 77 = 53 ```
        - ``` Region[53] = "1" ```
- Step 3: ``` "&61kujla" ```

https://www.codewars.com/kata/5782b5ad202c0ef42f0012cb
