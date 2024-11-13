
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium84";
        public override double halfLife { get; } = 2370.0d;
        public override double atomicWeight { get; } = 83.92067d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium84() } },

        };
    }
}
    
    