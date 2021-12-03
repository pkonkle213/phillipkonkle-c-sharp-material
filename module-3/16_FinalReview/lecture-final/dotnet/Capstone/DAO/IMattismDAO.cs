using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface IMattismDAO
    {
        Mattism AddMattism(int userId, Mattism itemToAdd);
        IEnumerable<Mattism> GetAllMattisms();
    }
}