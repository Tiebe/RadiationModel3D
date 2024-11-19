using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium198 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium198";
        public override double halfLife { get; } = 105.6d;
        public override double atomicWeight { get; } = 197.98339d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.57d, new List<RadioactiveSubstance> { new AlphaParticle(7332002.09), new Lead194() } },
            { 0.43d, new List<RadioactiveSubstance> { new BetaParticle(1, 3901000.0), new Bismuth198() } },

        };
    }
}
    
    