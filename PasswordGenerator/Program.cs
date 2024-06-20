namespace PasswordGenerator;

//Правила создания пароля:
//1)Пароль должен быть длинной от 6 до 16 символов.
//2)Наличие строчных и заглавных букв.
//3)Наличие цифр.
//Запрещенно использование иных символов.

class Program
{
    public static bool ChooseLetterOrDigit()
    {
        Random rand = new Random();
        if (rand.Next(1, 3) == 1)
        {
            return true;
        }
        return false;
    }
    public static bool ChooseLetterSize()
    {
        Random rand = new Random();
        if (rand.Next(1, 3) == 1)
        {
            return true;
        }    
        return false;
    }
    static void Main(string[] args)
    {
        char[] capitalLetters = new char[26] 
        {
            'A', 'B', 'C', 'D', 'E', 'F',
            'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'Q', 'R',
            'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        char[] lowercaseLetters = new char[26]
        {
            'a', 'b', 'c', 'd', 'e', 'f',
            'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'q', 'r',
            's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        Random rand = new Random();
        byte passwordLength = (byte)rand.Next(6, 16);

        string password = "";

        for(byte count = 0; count < passwordLength; count++)
        {
            if (ChooseLetterOrDigit() == true)
            {
                Random random = new Random();
                password += random.Next(1, 11);
            }
            else
            {
                if (ChooseLetterSize() == false)
                {
                    Random random = new Random();
                    byte letter = (byte)random.Next(1, 26);
                    password += capitalLetters[letter];
                }
                else
                {
                    Random random = new Random();
                    byte letter = (byte)random.Next(1, 26);
                    password += lowercaseLetters[letter];
                }
            }
        }

        Console.WriteLine(password);
    }
}