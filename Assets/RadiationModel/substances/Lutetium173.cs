
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium173";
        public override double halfLife { get; } = 43233024.24d;
        public override double atomicWeight { get; } = 172.93894d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Ytterbium173() } },

        };
    }
}
    
    