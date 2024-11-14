using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium97m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium97m";
        public override double halfLife { get; } = 58.7d;
        public override double atomicWeight { get; } = 96.9089d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00167), new Niobium97() } },

        };
    }
}
    
    