using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium194m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium194m";
        public override double halfLife { get; } = 0.03185d;
        public override double atomicWeight { get; } = 193.96523d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00843), new Iridium194() } },

        };
    }
}
    
    