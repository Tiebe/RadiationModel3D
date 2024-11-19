using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium206m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium206m";
        public override double halfLife { get; } = 0.041d;
        public override double atomicWeight { get; } = 206.0147d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9185002.09), new Francium202() } },

        };
    }
}
    
    