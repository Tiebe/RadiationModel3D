
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth219 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth219";
        public override double halfLife { get; } = 8.7d;
        public override double atomicWeight { get; } = 219.01752d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Polonium219() } },

        };
    }
}
    
    