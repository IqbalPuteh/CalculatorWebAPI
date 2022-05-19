namespace CalculatorWebAPI
{
    public class clsMultiply : ICalculate2Num
    {
        private double _valA = 0;
        private double _valB = 0;   
        public clsMultiply(double valA, double valB)
        {
            _valA = valA;
            _valB = valB;
        }
        public double Calculate()
        { return _valA * _valB; }   
    }
}
