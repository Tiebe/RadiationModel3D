
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium106";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 105.96318d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium106() } },

        };
    }
}
    
    