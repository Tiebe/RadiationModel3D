using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium86m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium86m";
        public override double halfLife { get; } = 61.02d;
        public override double atomicWeight { get; } = 85.91176d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((556050.0, 0.00223)), new Rubidium86() } },
            { 0.003d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2332150.0), new Strontium86() } },

        };
    }
}
    
    