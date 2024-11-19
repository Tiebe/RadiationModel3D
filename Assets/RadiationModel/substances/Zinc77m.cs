using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc77m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc77m";
        public override double halfLife { get; } = 1.05d;
        public override double atomicWeight { get; } = 76.93772d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.66d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7975600.0), new Gallium77() } },
            { 0.34d, new List<RadioactiveSubstance> { new GammaParticle(0.00161, 772400.0), new Zinc77() } },

        };
    }
}
    
    