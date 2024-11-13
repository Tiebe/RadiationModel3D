
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium88";
        public override double halfLife { get; } = 7205760.0d;
        public override double atomicWeight { get; } = 87.91022d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Yttrium88() } },

        };
    }
}
    
    