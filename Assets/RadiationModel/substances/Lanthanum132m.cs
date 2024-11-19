using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum132m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum132m";
        public override double halfLife { get; } = 1458.0d;
        public override double atomicWeight { get; } = 131.91033d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.76d, new List<RadioactiveSubstance> { new GammaParticle(0.00653, 190000.0), new Lanthanum132() } },
            { 0.24d, new List<RadioactiveSubstance> { new BetaParticle(1, 4904900.0), new Barium132() } },

        };
    }
}
    
    