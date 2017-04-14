using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump{

    class Program{

        static void Main(string[] args){

            char ch;
            Console.WriteLine("Select model for activation: ");
            Console.WriteLine("1. GasPump-1");
            Console.WriteLine("2. GasPump-2");
            ch = Console.ReadKey().KeyChar;

            if (ch == '1'){
                GasPump1 gP1;

                Console.WriteLine("GasPump-1");
                Console.WriteLine("Menu");
                Console.WriteLine("0. Activate(float, float)");
                Console.WriteLine("1. Start()");
                Console.WriteLine("2. PayCredit()");
                Console.WriteLine("3. Reject()");
                Console.WriteLine("4. Cancel()");
                Console.WriteLine("5. Approved()");
                Console.WriteLine("6. Super()");
                Console.WriteLine("7. Regular()");
                Console.WriteLine("8. StartPump()");
                Console.WriteLine("9. PumpGallon()");
                Console.WriteLine("s. StopPump()");
                Console.WriteLine("q. Quit");

                Console.WriteLine("GasPump-1 Execution Feed:");

                while (ch != 'q'){

                    Console.WriteLine("Select Operation: ");
                    Console.WriteLine("0. Activate, 1. Start, 2. PayCredit, 3. Reject 4. Cancel, 5. Approved,");
                    Console.WriteLine("6. Super, 7. Regular, 8. StartPump, 9. PumpGallon, s. StopPump, q. Quit");
                    ch = Console.ReadKey().KeyChar;

                    switch (ch){
                        case '0': {
                                float a, b;
                                Console.WriteLine("Operation: Activate(float a, float b)");
                                Console.WriteLine("Please enter a value for parameter a: ");
                                a = float.Parse(Console.ReadLine());
                                Console.WriteLine("Please enter a value for parameter b: ");
                                b = float.Parse(Console.ReadLine());
                                gP1.activate(a, b);
                                break;
                        }
                        case '1': {
                                Console.WriteLine("Operation: Start()");
                                gP1.start();
                                break;
                        }
                        case '2': {
                                Console.WriteLine("Operation: PayCredit()");
                                gP1.payCredit();
                                break;
                        }
                        case '3':
                            {
                                Console.WriteLine("Operation: Reject()");
                                gP1.reject();
                                break;
                        }
                        case '4':
                            {
                                Console.WriteLine("Operation: Cancel()");
                                gP1.cancel();
                                break;
                        }
                        case '5':
                            {
                                Console.WriteLine("Operation: Approved()");
                                gP1.approved();
                                break;
                        }
                        case '6':
                            {
                                Console.WriteLine("Operation: Super()");
                                gP1.super();
                                break;
                        }
                        case '7':
                            {
                                Console.WriteLine("Operation: Regular()");
                                gP1.regular();
                                break;
                        }
                        case '8':
                            {
                                Console.WriteLine("Operation: StartPump()");
                                gP1.startPump();
                                break;
                        }
                        case '9':
                            {
                                Console.WriteLine("Operation: PumpGallon()");
                                gP1.pumpGallon();
                                break;
                        }
                        case 's':
                            {
                                Console.WriteLine("Operation: StopPump()");
                                gP1.stopPump();
                                break;
                        }

                    }

                }

            }
            else if (ch == '2'){
                GasPump2 gP2;

                Console.WriteLine("GasPump-2");
                Console.WriteLine("Menu");
                Console.WriteLine("0. Activate(int, int, int)");
                Console.WriteLine("1. Start()");
                Console.WriteLine("2. PayCash(int)");
                Console.WriteLine("3. Cancel()");
                Console.WriteLine("4. Premium()");
                Console.WriteLine("5. Regular()");
                Console.WriteLine("6. Super()");
                Console.WriteLine("7. StartPump()");
                Console.WriteLine("8. PumpLiter()");
                Console.WriteLine("s. Stop()");
                Console.WriteLine("r. Receipt()");
                Console.WriteLine("n. NoReceipt()");
                Console.WriteLine("q. Quit");

                Console.WriteLine("GasPump-1 Execution Feed:");

                while (ch != 'q')
                {

                    Console.WriteLine("Select Operation: ");
                    Console.WriteLine("0. Activate, 1. Start, 2. PayCredit, 3. Reject 4. Cancel, 5. Approved,");
                    Console.WriteLine("6. Super, 7. Regular, 8. StartPump, 9. PumpGallon, s. StopPump, q. Quit");
                    ch = Console.ReadKey().KeyChar;

                    switch (ch)
                    {
                        case '0':
                            {
                                int a, b, c;
                                Console.WriteLine("Operation: Activate(int a, int b, int c)");
                                Console.WriteLine("Please enter a value for parameter a: ");
                                a = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please enter a value for parameter b: ");
                                b = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please enter a value for parameter c: ");
                                c = int.Parse(Console.ReadLine());
                                gP2.activate(a, b, c);
                                break;
                            }
                        case '1':
                            {
                                Console.WriteLine("Operation: Start()");
                                gP2.start();
                                break;
                            }
                        case '2':
                            {
                                Console.WriteLine("Operation: PayCash(int c)");
                                Console.WriteLine("Please enter an amount to pay.");
                                int c;
                                c = int.Parse(Console.ReadLine());
                                gP2.payCash(c);
                                break;
                            }
                        case '3':
                            {
                                Console.WriteLine("Operation: Cancel()");
                                gP2.cancel();
                                break;
                            }
                        case '4':
                            {
                                Console.WriteLine("Operation: Premium()");
                                gP2.premium();
                                break;
                            }
                        case '5':
                            {
                                Console.WriteLine("Operation: Regular()");
                                gP2.regular();
                                break;
                            }
                        case '6':
                            {
                                Console.WriteLine("Operation: Super()");
                                gP2.super();
                                break;
                            }
                        case '7':
                            {
                                Console.WriteLine("Operation: StartPump()");
                                gP2.startPump();
                                break;
                            }
                        case '8':
                            {
                                Console.WriteLine("Operation: PumpLiter()");
                                gP2.pumpliter();
                                break;
                            }
                        case 's':
                            {
                                Console.WriteLine("Operation: Stop()");
                                gP2.stop();
                                break;
                            }
                        case 'r':
                            {
                                Console.WriteLine("Operation: Receipt()");
                                gP2.receipt();
                                break;
                            }
                        case 'n':
                            {
                                Console.WriteLine("Operation: NoReceipt()");
                                gP2.noReceipt();
                                break;
                            }

                    }

                }
            }
        }
    }
}
