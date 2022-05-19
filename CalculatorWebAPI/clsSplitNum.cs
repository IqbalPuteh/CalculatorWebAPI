namespace CalculatorWebAPI
{
    public class clsSplitNum : ICalculate2Num
    {

        private double _result1 = 0;
        private double _result2 = 0;    
        public clsSplitNum(double valA, double valB, double valC, double valD, clsMod CalculatMod)
        {
            _result1 = CalculatMod.Calculate();
        }

        
        public  double  Calculate() 
        {
            return _result1 + _result2;
        }
        
    }
}
