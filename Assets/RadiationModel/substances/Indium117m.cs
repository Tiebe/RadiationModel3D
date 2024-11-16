using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium117m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium117m";
        public override double halfLife { get; } = 6972.0d;
        public override double atomicWeight { get; } = 116.90485d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.529d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1769700.0), new Tin117() } },
            { 0.47100000000000003d, new List<RadioactiveSubstance> { new GammaParticle(0.00394), new Indium117() } },

        };
    }
}
    
    