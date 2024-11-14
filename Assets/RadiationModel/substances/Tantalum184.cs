using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum184 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum184";
        public override double halfLife { get; } = 31320.0d;
        public override double atomicWeight { get; } = 183.95401d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2866500.0), new Tungsten184() } },

        };
    }
}
    
    