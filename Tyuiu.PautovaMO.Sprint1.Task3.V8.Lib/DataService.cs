using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PautovaMO.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            return (startAmount * percent * timeDays) / (365*100);
        }
    }
}
