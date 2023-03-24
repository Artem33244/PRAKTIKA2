using ClassLibrary3;

CaesarCipher cipher = new CaesarCipher(3);

string plaintext = "PRAKTIKASPEEDRUN1DAYLEFT";
string ciphertext = cipher.Encrypt(plaintext);
string decrypted = cipher.Decrypt(ciphertext);

Console.WriteLine("Original text: " + plaintext);
Console.WriteLine("Encrypted text: " + ciphertext);
Console.WriteLine("Decrypted text: " + decrypted);