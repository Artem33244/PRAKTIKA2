namespace ClassLibrary3
{
    public class CaesarCipher
    {
        private int shift;

        public CaesarCipher(int shift)
        {
            this.shift = shift;
        }

        public string Encrypt(string plaintext)
        {
            char[] plaintextChars = plaintext.ToCharArray();
            for (int i = 0; i < plaintextChars.Length; i++)
            {
                plaintextChars[i] = ShiftCharacter(plaintextChars[i], shift);
            }
            return new string(plaintextChars);
        }

        public string Decrypt(string ciphertext)
        {
            char[] ciphertextChars = ciphertext.ToCharArray();
            for (int i = 0; i < ciphertextChars.Length; i++)
            {
                ciphertextChars[i] = ShiftCharacter(ciphertextChars[i], -shift);
            }
            return new string(ciphertextChars);
        }

        private char ShiftCharacter(char c, int shift)
        {
            if (!char.IsLetter(c))
            {
                return c;
            }
            char baseChar = char.IsUpper(c) ? 'A' : 'a';
            return (char)(((c - baseChar + shift + 26) % 26) + baseChar);
        }
    }
}