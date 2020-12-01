using SandBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBox.Interfaces
{
    interface IAllDoramas
    {
        IEnumerable<Doramas> Doramas { get; }
        Doramas getObjectDorama(int DoramaId);
    }
}
