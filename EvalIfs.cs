class Program
            {
                public static void Main(string[] args)
                {
                    Console.Write("Enter First Number: ");
                    double firstNumber = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Second Number: ");
                    double secondNumber = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Please enter an operation: ");
                    string? input = Console.ReadLine();

                    double result;

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Please enter the operator value.");
                    }
                    else
                    {
                        if (!char.IsLetter(input![0]))
                            
                            if (input.Length > 1)
                            {
                                switch (input)
                                {
                                    case "plus":
                                        result = firstNumber + secondNumber;
                                        Console.Write("Result: {0} ", result);
                                        break;
                                    case "minus":
                                        result = firstNumber - secondNumber;
                                        Console.Write("Result: {0} ", result);
                                        break;
                                    case "multiply":
                                        result = firstNumber * secondNumber;
                                        Console.Write("Result: {0} ", result);
                                        break;
                                    case "divide":
                                        result = firstNumber / secondNumber;
                                        Console.Write("Result: {0} ", result);
                                        break;
                                    default:
                                        Console.WriteLine("Invalid input");
                                        break;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Please supply the complete text of the operator.");
                            }
                    
                        else
                    
                        if (input.Length > 1)
                        {
                            Console.WriteLine("Invalid Operator");
                        }
                        else
                        {
                            switch (input)
                            {
                                case "+":
                                    result = firstNumber + secondNumber;
                                    Console.Write("Result: {0} ", result);
                                    break;
                                case "-":
                                    result = firstNumber - secondNumber;
                                    Console.Write("Result: {0} ", result);
                                    break;
                                case "*":
                                    result = firstNumber * secondNumber;
                                    Console.Write("Result: {0} ", result);
                                    break;
                                case "/":
                                    result = firstNumber / secondNumber;
                                    Console.Write("Result: {0} ", result);
                                    break;
                                default:
                                    Console.WriteLine("Invalid input");
                                    break;
                            }
                        }

                    }
                    
                }
            }
