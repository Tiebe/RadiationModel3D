
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony120m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony120m";
        public override double halfLife { get; } = 497664.0d;
        public override double atomicWeight { get; } = 119.90508d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin120() } },

        };
    }
}
    
    