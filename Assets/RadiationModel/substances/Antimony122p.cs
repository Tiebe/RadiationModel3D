using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony122p : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony122p";
        public override double halfLife { get; } = 251.46d;
        public override double atomicWeight { get; } = 121.90534d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00758, 163600.0), new Antimony122() } },

        };
    }
}
    
    