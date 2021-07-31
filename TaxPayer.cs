namespace TaxCalculation
{
    public static class TaxPayer
    {
        /*  public static double _income { get; set; }
          public static string _type { get; set; }*/

        public static double taxCalculation(double taxFree, double taxAble)
        {
            taxAble -= taxFree;
            if (taxAble < 0) return 0;
            double temp = 0.0;
            double calculatedTax = 0;
            temp = taxAble >= 100000 ? 100000 : taxAble;
            calculatedTax += (0.05 * temp);
            taxAble -= 100000;
            if (taxAble < 0) return calculatedTax;
            temp = taxAble >= 300000 ? 300000 : taxAble;
            calculatedTax += (0.10 * temp);
            taxAble -= 300000;
            if (taxAble < 0) return calculatedTax;
            temp = taxAble >= 400000 ? 400000 : taxAble;
            calculatedTax += (0.15 * temp);
            taxAble -= 400000;
            if (taxAble < 0) return calculatedTax;
            temp = taxAble >= 500000 ? 500000 : taxAble;
            calculatedTax += (0.20 * temp);
            taxAble -= 500000;
            if (taxAble < 0) return calculatedTax;
            temp = taxAble;
            calculatedTax += (0.25 * temp);
            taxAble = 0;
            if (taxAble < 0) return calculatedTax;
            else return calculatedTax;
            //return 0;
        }

        public static double taxCredit(double allowableInvestment)
        {
            double taxcredit = 0.0;
            if (allowableInvestment < 250000) return allowableInvestment * 0.15;
            taxcredit += allowableInvestment * 0.15;
            allowableInvestment -= 250000;
            if (allowableInvestment > 0)
            {
                taxcredit += allowableInvestment * 0.12;
            }
            return taxcredit;

        }

    }

}
