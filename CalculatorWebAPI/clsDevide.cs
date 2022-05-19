namespace CalculatorWebAPI
{
    public class clsDevide: ICalculate2Num
    {
        private readonly double _valA = 1;
        private readonly double _valB = 1;

        public clsDevide(double valA, double valB)
        {
            if (valA != 0) { _valA = valA; }
            
            if (valB != 0) { _valB = valB; }
        }

        public double Calculate()
        {
            return _valA / _valB;
        }

    }
}
