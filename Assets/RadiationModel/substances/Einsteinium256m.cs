
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium256m : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium256m";
        public override double halfLife { get; } = 1524.0d;
        public override double atomicWeight { get; } = 256.0936d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Fermium256() } },

        };
    }
}
    
    