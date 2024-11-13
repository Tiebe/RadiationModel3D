
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth206 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth206";
        public override double halfLife { get; } = 539395.2d;
        public override double atomicWeight { get; } = 205.9785d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead206() } },

        };
    }
}
    
    