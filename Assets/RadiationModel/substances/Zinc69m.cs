using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc69m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc69m";
        public override double halfLife { get; } = 49489.2d;
        public override double atomicWeight { get; } = 68.92702d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99967d, new List<RadioactiveSubstance> { new GammaParticle(0.00283, 438600.0), new Zinc69() } },
            { 0.00033d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1348500.0), new Gallium69() } },

        };
    }
}
    
    