namespace CalculatorWebAPI
{
    public class clsAdd : ICalculate2Num
    {
        double _valA = 0;
        double _valB = 0;

        public clsAdd(double valA, double valB)
        { _valA = valA; _valB = valB; }

        public double Calculate()
        {
            return _valA + _valB;
        }
    }
}
