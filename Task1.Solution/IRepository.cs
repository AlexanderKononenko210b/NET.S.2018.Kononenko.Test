using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    /// <summary>
    /// Strategy for create password for any repository
    /// </summary>
    public interface IRepository
    {
        void Create(string password);
    }
}
