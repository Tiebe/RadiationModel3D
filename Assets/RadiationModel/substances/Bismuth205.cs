
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth205 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth205";
        public override double halfLife { get; } = 1288224.0d;
        public override double atomicWeight { get; } = 204.97738d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead205() } },

        };
    }
}
    
    