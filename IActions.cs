using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveDragon
{
    interface IActions
    {
        bool UseMamaMamaCombination();
        bool UseMamaPapaNestCombination();
        bool UsePapaPapaCombination();
        bool UseThieftCombination();
        bool UseThrowCardCombination();
    }
}
