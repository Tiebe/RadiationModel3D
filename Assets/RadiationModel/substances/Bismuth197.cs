
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth197 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth197";
        public override double halfLife { get; } = 559.8d;
        public override double atomicWeight { get; } = 196.97887d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead197() } },

        };
    }
}
    
    