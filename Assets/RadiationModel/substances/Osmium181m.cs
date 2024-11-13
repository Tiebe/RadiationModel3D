
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium181m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium181m";
        public override double halfLife { get; } = 162.0d;
        public override double atomicWeight { get; } = 180.9533d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhenium181() } },

        };
    }
}
    
    