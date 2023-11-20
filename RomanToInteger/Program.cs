// See https://aka.ms/new-console-template for more information

/*
    Roman numerals are a numeral system that originated in ancient Rome and
    remained the usual way of writing numbers throughout Europe well into the
    Late Middle Ages. Numbers are written with combinations of letters from the
    Latin alphabet, each letter with a fixed integer value. Modern style uses
    only these seven:

    ------------------
    | Symbol | Value |
    ------------------
    | I      | 1     |
    | V      | 5     |
    | X      | 10    |
    | L      | 50    |
    | C      | 100   |
    | D      | 500   |
    | M      | 1000  |
    ------------------

    The numerals for 4 (IV) and 9 (IX) are written using subtractive notation,
    where the smaller symbol (I) is subtracted from the larger one (V, or X),
    thus avoiding the clumsier IIII and VIIII.[a] Subtractive notation is also
    used for 40 (XL), 90 (XC), 400 (CD) and 900 (CM).[6] These are the only
    subtractive forms in standard use.
    
    Given this nature, one way to convert a roman numeral to integer could be:
    
    - Take the value of the last symbol to compare it with the second last
    - Cycle from the second last to the first symbol comparing its values
    - If the value is smaller than the next, they have to be subtracted
    - If the value is bigger than the next, they have to be be added
*/

string roman = "MCMLXXVII"; // 1977
int integer = 0;

Dictionary<char, int> symbolsAndValues = new()
{
    { 'I', 1 },
    { 'V', 5 },
    { 'X', 10 },
    { 'L', 50 },
    { 'C', 100 },
    { 'D', 500 },
    { 'M', 1000 }
};

var symbols = roman.ToCharArray();

// Take the value of the last symbol to compare it with the second last
integer = symbolsAndValues[symbols.Last()];

// Cycle from the second last to the first symbol comparing its values
for (int i = symbols.Length - 2; i >= 0; i--)
{
    var symbol = symbols[i];
    var nextSymbol = symbols[i+1];
    var valueOfSymbol = symbolsAndValues[symbol];
    var valueOfNextSymbol = symbolsAndValues[nextSymbol];

    // If the first value is smaller than the next, they have to be subtracted
    if ( valueOfSymbol < valueOfNextSymbol)
    {
        integer -= valueOfSymbol;
    }
    else
    {
        // If the value is bigger than the next, they have to be be added
        integer += valueOfSymbol;
    }
}

Console.WriteLine(integer.ToString());
