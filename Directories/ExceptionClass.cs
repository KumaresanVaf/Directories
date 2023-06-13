namespace Directories
{
    public class Arithmatic
    {
        public void exep()
        {
            int num1 = 1;
            while (num1 <= 2)
            {
                try
                {
                    Console.Write("Enter the first number: ");
                    int number1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    int number2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Addition: {number1 + number2}");
                    Console.WriteLine($"Subtraction: {number1 - number2}");
                    Console.WriteLine($"Multiplication: {number1 * number2}");

                    if (number2 == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }

                    Console.WriteLine($"Division: {number1 / number2}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid integers.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                num1++;
            }

            Console.WriteLine();
        }
    }

    public class Filecheck
    {
        public void method()
        {
            try
            {
                string filePath = @"C:\Users\visualapp\Downloads\Customers.txt";
                string content = ReadFileContent(filePath);

                Console.WriteLine("File content:");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Directory not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An I/O error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine();
        }

        private static string ReadFileContent(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}