using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium192m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium192m";
        public override double halfLife { get; } = 87.0d;
        public override double atomicWeight { get; } = 191.96266d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.02187, 56700.0), new Iridium192() } },
            { 0.00017500000000000003d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1509600.0), new Platinum192() } },

        };
    }
}
    
    