
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium84m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium84m";
        public override double halfLife { get; } = 4.6d;
        public override double atomicWeight { get; } = 83.92074d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium84() } },

        };
    }
}
    
    