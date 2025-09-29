using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PautovaMO.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            var sign = 0;
            var word = 0;
            foreach (var ch in value)
            {
                if (char.IsLetter(ch))
                {
                    word++;
                }
                else
                {
                    sign++;
                }
            }
            if (word > sign)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
