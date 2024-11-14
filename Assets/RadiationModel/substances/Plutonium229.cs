using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium229";
        public override double halfLife { get; } = 91.0d;
        public override double atomicWeight { get; } = 229.04014d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.5d, new List<RadioactiveSubstance> { new AlphaParticle(8613047.4), new Uranium225() } },
            { 0.5d, new List<RadioactiveSubstance> { new BetaParticle(1, 3590000.0), new Neptunium229() } },
            { 0.07d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    