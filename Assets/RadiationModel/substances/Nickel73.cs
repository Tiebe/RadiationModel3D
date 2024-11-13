
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel73 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel73";
        public override double halfLife { get; } = 0.84d;
        public override double atomicWeight { get; } = 72.94621d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Copper73() } },

        };
    }
}
    
    