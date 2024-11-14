using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium43 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium43";
        public override double halfLife { get; } = 14007.6d;
        public override double atomicWeight { get; } = 42.96115d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2220770.0), new Calcium43() } },

        };
    }
}
    
    