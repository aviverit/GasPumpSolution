using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class OutputProcessor
    {

        public void payMsg(){
            Console.WriteLine("Please insert payment. ");
        }    

        public void storeCash(){

        }

        public void displayMenu(){
            Console.WriteLine("Menu");
        }

        public void rejectMsg(){
            Console.WriteLine("Sorry, but your card was declined. ");
        }

        public void setPrice(int gT){

        }

        public void setInitialValues(){

        }

        public void readyMsg(){
            Console.WriteLine("Pump is now ready. Please insert into tank and begin fueling. ");
        }

        public void pumpOnce(){}

        public void gasPumpedMsg(){
            Console.WriteLine(gQ+" "+gT+" have been pumped.");
        }

        public void stopMsg(){
            Console.WriteLine("Finished Fueling. Thank you for choosing us.");
        }

        public void returnCash(){

        }

        public void receipt(){

        }

        public void noReceipt(){

        }
    }
}
