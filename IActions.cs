using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveDragon
{
    interface IActions
    {
        bool useMamaMamaCombination();
        bool useMamaPapaNestCombination();
        bool usePapaPapaCombination();
        bool useThieftCombination();
        bool useThrowCardCombination();
    }
}
