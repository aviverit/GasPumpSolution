using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class OutputProcessor
    {

        int pricePerUnit;
        AbstractFactory factory;
        PriceStrategy priceStrat;
        CashPaymentStrategy cashPS;
        CreditPaymentStrategy credPS;
        DataStorage dS = DataStorage.Instance;

        public OutputProcessor() {
            if (dS.getGQ() == 0)
            {
                factory = new GP1ConcreteFactory();
            }
            else if (dS.getGQ() == 1) {
                factory = new GP2ConcreteFactory();
            }
        }

        public void payMsg(){
            Console.WriteLine("Please insert payment. ");
        }    

        public void displayMenu(){
            Console.WriteLine("Menu");
        }

        public void rejectMsg(){
            Console.WriteLine("Sorry, but your card was declined. ");
        }

        public void cancelMsg() {
            Console.WriteLine("This transaction has been successfully cancelled.");
        }

        public void setPrice(int gT)
        {
            /*if (gT == 0)
            {
                priceStrat = new RegularPriceStrategy();
            }
            else if (gT == 1)
            {
                priceStrat = new SuperPriceStrategy();
            }
            else if (gT == 2)
            {
                priceStrat = new PremiumPriceStrategy();
            }*/
            priceStrat = factory.getPriceStrat();

            pricePerUnit = priceStrat.getPrice(gT);

            dS.setPrice(pricePerUnit);
        }

        public void setInitialValues(){
            dS.set1Gallon(0);
            dS.set2Liter(0);
        }

        public void readyMsg(){
            Console.WriteLine("Pump is now ready. Please insert into tank and begin fueling. ");
        }

        public void pumpOnce(){
            if (dS.getGQ() == 0)
            {
                dS.set1Gallon((dS.get1Gallon() + 1));
            } else if (dS.getGQ() == 1) {
                dS.set2Liter(dS.get2Liter() + 1);
            }
        }

        public void gasPumpedMsg(){
            if (dS.getGQ() == 0)
            {
                Console.WriteLine(dS.get1Gallon() + " gallons have been pumped.");
            }
            else if (dS.getGQ() == 1) {
                Console.WriteLine(dS.get2Liter() + " liters have been pumped.");
            }
        }

        public void stopMsg(){
            Console.WriteLine("Finished Fueling. Thank you for choosing us.");
        }

        public void returnCash(){

        }

        public void receipt(){
            Console.WriteLine("Please collect printing receipt and have a nice day.");
        }

        public void noReceipt(){
            Console.WriteLine("Thank you for choosing us.");
        }
    }
}
