using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface IMattismDAO
    {
        IEnumerable<Mattism> GetAllMattisms();
    }
}