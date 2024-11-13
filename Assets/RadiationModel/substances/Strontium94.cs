
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium94";
        public override double halfLife { get; } = 75.3d;
        public override double atomicWeight { get; } = 93.91536d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium94() } },

        };
    }
}
    
    