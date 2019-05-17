using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IFuel
    {
        // Método da interface, nenhum método/propriedade de interfaces
        // tem corpo e são public abstract por omissão
        float Efficiency { get; }
        void Burn(); 
    }
}
