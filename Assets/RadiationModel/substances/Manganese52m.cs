
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese52m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese52m";
        public override double halfLife { get; } = 1266.0d;
        public override double atomicWeight { get; } = 51.94596d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9822d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium52() } },

            { 0.0178d, new List<RadioactiveSubstance> { new GammaParticle(), new Manganese52() } },

        };
    }
}
    
    