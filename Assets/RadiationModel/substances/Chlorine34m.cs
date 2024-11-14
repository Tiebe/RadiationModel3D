using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine34m : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine34m";
        public override double halfLife { get; } = 1919.4d;
        public override double atomicWeight { get; } = 33.97392d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.5539999999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 5637960.0), new Sulfur34() } },
            { 0.446d, new List<RadioactiveSubstance> { new GammaParticle(0.00847), new Chlorine34() } },

        };
    }
}
    
    