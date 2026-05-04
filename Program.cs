// See https://aka.ms/new-console-template for more information
using System.Runtime;

public class BillingStrategy
{
    int usage,rate;
    public static int FlatRate(int rate)
    {
        return rate;
    }
    public static int UsageBase(int usage,int rate)
    {
        return rate*usage;
    }
    public class InvoiceManagement
    {
        public static void Draft()
        {
            Console.WriteLine("Invoice Drafted Successfully");

        }
        public static void Finalized()
        {
            Console.WriteLine("Invoice Finalized Successfully");
        }
        public static void Paid()
        {
            Console.WriteLine("Invoice Paid Successfully");
        }
    }
    public class IDiscountPolicy
    {
        int amount,discount,threshold;
        public static int SeasonalDiscount(int amount,int discount)
        {
            return amount-discount;
        }
        public static int VolumeDiscount(int amount,int discount,int threshold)
        {
            if (amount < threshold)
            {
                return amount-discount;
            }
            return amount;
        }
    }
}