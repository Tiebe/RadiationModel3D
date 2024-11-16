using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium82m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium82m";
        public override double halfLife { get; } = 23299.2d;
        public override double atomicWeight { get; } = 81.91828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4472995.0), new Krypton82() } },
            { 0.0033d, new List<RadioactiveSubstance> { new GammaParticle(0.01792), new Rubidium82() } },

        };
    }
}
    
    