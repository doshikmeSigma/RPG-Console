using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Console.Items
{
    public interface IEffect
    {
        void Apply();
        void GetUsageDescription();
        string GetEffectDescription();

    }
}
