namespace CalculatorWebAPI
{
    public class clsSubtract : ICalculate2Num
    {
        private double _valA = 0, _valB = 0;

        public clsSubtract(double valA, double valB)
        {
            _valA = valA;
            _valB = valB;
        }
        public double Calculate()
        {
            return _valA - _valB;
        }
    }
}
