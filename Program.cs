// See https://aka.ms/new-console-template for more information
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
        int discount;
        public static int SeasonalDiscount(int discount)
        {
            return discount;
        }
    }
}