// See https://aka.ms/new-console-template for more information

int num;
int pal = 0;
int cnt = 0; //count
int rem = 0;

Console.WriteLine("Enter a number to check if it is palindrome: ");
num = Convert.ToInt32(Console.ReadLine());

// Setting temp to num in order to count the number of digits.
int temp = num;
while (temp != 0)
{
    temp /= 10;
    cnt++;
}

/**
 * _pow - returns the product of dig and 10 ^ e-1.
 * @dig: a single digit of the user input number.
 * @e: e - 1 is exponent of base 10;
 * Return: dig (holds the product).
 */
int _pow(int dig, int e)
{
    for (int i = 0; i < e - 1; i++)
    {
        dig *= 10;
    }
    return dig;
}
//Reassigning temp to find the reversed number of the input number.
temp = num;
while (temp != 0)
{
    rem = temp % 10;
    pal += _pow(rem, cnt--);
    temp /= 10;
}
//Here checks if pal is equal with num.
if (pal == num)
    Console.WriteLine(num + " is Palindrome\n ");
else
    Console.WriteLine(num + " is not Palindrome");




