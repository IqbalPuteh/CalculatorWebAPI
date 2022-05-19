using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>

        [HttpGet("add")]
        public double Add(double valA, double valB)
        {
            var cls = new clsAdd(valA,valB);
            
            return cls.Calculate();
        }

        [HttpGet("subtract")]
        public double Subtract(double valA, double valB)
        {
            var cls = new clsSubtract(valA, valB);

            return cls.Calculate();
        }

        [HttpGet("multiply")]
        public double Multiply(double valA, double valB)
        {
            var cls = new clsMultiply(valA, valB);

            return cls.Calculate();
        }

        //[HttpGet("devide")]
        //public double Devide(double valA, double valB)
        //{
        //    //if (valB == 0)
        //    //{
        //    //    throw new Exception("Second parameter cannot be empty or zero");

        //    //}
        //    var cls = new clsDevide(valA, valB);

        //    return cls.Calculate();
        //}



        [HttpGet("splitEqual")]
        public double[] SplitEqual(double valA, int valB)
        {
            var cls = new clsDevide(valA, Convert.ToDouble(valB));
            var value = cls.Calculate();
            double[] number = new double[valB];

            int i = 0;
            while (i < valB)
            {
                number[i] = value;
                i++;
            }

            return number;
        }

        [HttpGet("splitNum")]
        public double SplitNum(double valA, double valB, double valC = 0, double valD = 0)
        {
            //if (valB == 0)
            //{
            //    throw new Exception("Second parameter cannot be empty or zero");

            //}
            var cls1 = new clsSubtract(valA, valB);
            var cls2 = new clsSubtract(cls1.Calculate(), valC);
            var cls3 = new clsSubtract(cls2.Calculate(), valD);

            return cls3.Calculate();

        }

        [HttpGet("devide")]
        public double Devide(double valA, double valB )
        {
                var cls = new clsDevide(valA, valB);
                return cls.Calculate();
            
        }
    }
}
