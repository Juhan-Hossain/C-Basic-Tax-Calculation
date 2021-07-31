namespace TaxCalculation
{
    public static class TaxableAmount
    {
        /*public static double _income;
        public static string _type { get; set; }
        */
        public static double taxAmount(double income)
        {
            double basic = 0.6 * income;
            double HouseRentAllowance;
            if (0.3 * income <= 25000) HouseRentAllowance = 0.0;
            else HouseRentAllowance = ((0.3 * income) - 25000.0);
            double conveyanceAllowance;
            if (0.04 * income <= 2500) conveyanceAllowance = 0.0;
            else conveyanceAllowance = (0.04 * income) - 2500.0;
            double medicalAllowance;
            if (0.06 * income <= 2500) medicalAllowance = 0.0;
            else medicalAllowance = (0.06 * income) - 2500.0;
            return basic + HouseRentAllowance + conveyanceAllowance + medicalAllowance;
        }

    }

}
