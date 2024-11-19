using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper70m : RadioactiveSubstance
    {
        public override string name { get; } = "Copper70m";
        public override double halfLife { get; } = 33.0d;
        public override double atomicWeight { get; } = 69.9325d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.52d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6689400.0), new Zinc70() } },
            { 0.48d, new List<RadioactiveSubstance> { new GammaParticle((101100.0, 0.01226)), new Copper70() } },

        };
    }
}
    
    