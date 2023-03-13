using System;

namespace midterm {
        class Program {
            static void Main(string[] args) => branch1();
                              
                static void branch1() {
                        Console.Write("Input Day: ");
                        int day = int.Parse(Console.ReadLine());
                        Console.Write("Input Time: ");

                        int time = int.Parse(Console.ReadLine());
                        int brft = 5;
                        int wk = 2;
                        int cfe = 3;

                        int orderbrft = brft--;
                        int orderwk = wk--;
                        int ordeecfe = cfe--;
                         Console.WriteLine("wk-- = {0}", orderwk);
                        if (day>0 && day<8 || time>7 && time<19); {
                            
                            Console.WriteLine("Please select menu");
                            Console.WriteLine("1.Breakfast Set");
                            Console.WriteLine("2.Weekend Set");
                            Console.WriteLine("3.Coffee");
                           

                            string input = Console.ReadLine();
                            switch(input) {
                            case "Weekend Set":
                                Console.Clear();
                                Console.Write("");
                                break;
                            case "Coffee":
                                Console.Clear();
                                Console.Write("Please enter a valid menu");
                                break;
                                default:
                                Console.WriteLine("incorrect");
                                break;
                        } 
                           
                            }
                            
                        
                            
                            

                            
    }
    }
}

                    
                     

            
                    
                     
                     
                     












                
             
        

