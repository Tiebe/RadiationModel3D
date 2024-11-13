
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium123";
        public override double halfLife { get; } = 3.8d;
        public override double atomicWeight { get; } = 122.93528d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum123() } },

        };
    }
}
    
    