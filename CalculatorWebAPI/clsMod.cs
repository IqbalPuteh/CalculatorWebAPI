namespace CalculatorWebAPI
{
    public class clsMod : ICalculate2Num
    {
        private double _valA = 0, _valB = 0;

        public clsMod(double valA, double valB)
        {
            _valA = valA;
            _valB = valB;
        }

        public double Calculate()
        {
            return _valA % _valB;
        }
    }
}
