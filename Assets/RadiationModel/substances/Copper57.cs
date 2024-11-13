
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper57 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper57";
        public override double halfLife { get; } = 0.1964d;
        public override double atomicWeight { get; } = 56.94921d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Nickel57() } },

        };
    }
}
    
    