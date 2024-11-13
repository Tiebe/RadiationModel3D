
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel53 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel53";
        public override double halfLife { get; } = 0.0552d;
        public override double atomicWeight { get; } = 52.96819d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt53() } },

        };
    }
}
    
    