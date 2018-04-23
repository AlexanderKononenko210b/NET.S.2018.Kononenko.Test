using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Broker
    {
        public string Name { get; set; }

        public void CourseChangeEventHandler(object sender, StockInfoEventArgs info)
        {
            Update(info);
        }

        public Broker(string name)
        {
            this.Name = name;
        }

        public void Update(object info)
        {
            StockInfoEventArgs sInfo = (StockInfoEventArgs)info;

            if (sInfo.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
        }
    }
}
