
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium208";
        public override double halfLife { get; } = 91452046.896d;
        public override double atomicWeight { get; } = 207.98125d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead204() } },

            { 4.2e-05d, new List<RadioactiveSubstance> { new BetaParticle(), new Bismuth208() } },

        };
    }
}
    
    