using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium92";
        public override double halfLife { get; } = 9399.6d;
        public override double atomicWeight { get; } = 91.91104d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1949000.0), new Yttrium92() } },

        };
    }
}
    
    