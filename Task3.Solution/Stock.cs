using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Stock
    {
        public event EventHandler<StockInfoEventArgs> CourseChange = delegate { };

        public void OnCourseChange(int usd, int euro)
        {
            CourseChange(this, new StockInfoEventArgs(usd, euro));
        }

        public void Market()
        {
            Random rnd = new Random();

            OnCourseChange(rnd.Next(20, 40), rnd.Next(30, 50));
        }
    }
}
