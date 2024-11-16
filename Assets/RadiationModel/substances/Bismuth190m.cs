using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth190m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth190m";
        public override double halfLife { get; } = 6.2d;
        public override double atomicWeight { get; } = 189.98876d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new List<RadioactiveSubstance> { new AlphaParticle(8008047.4), new Thallium186() } },

        };
    }
}
    
    