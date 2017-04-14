using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump{

    class Program{

        static void Main(string[] args){

            char c;
            Console.WriteLine("Select model for activation: ");
            Console.WriteLine("1. GasPump-1");
            Console.WriteLine("2. GasPump-2");
            c = Console.ReadKey().KeyChar;

            if (c == '1'){
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

                while (c != 'q'){

                    Console.WriteLine("Select Operation: ");
                    Console.WriteLine("0. Activate, 1. Start, 2. PayCredit, 3. Reject 4. Cancel, 5. Approved,");
                    Console.WriteLine("6. Super, 7. Regular, 8. StartPump, 9. PumpGallon, s. StopPump, q. Quit");
                    c = Console.ReadKey().KeyChar;

                    switch (c){
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
            else if (c == '2'){
                GasPump2 gP2;
            }
        }
    }
}
