using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium101";
        public override double halfLife { get; } = 0.1137d;
        public override double atomicWeight { get; } = 100.94061d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9730000.0), new Yttrium101() } },

        };
    }
}
    
    