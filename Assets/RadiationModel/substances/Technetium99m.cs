using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium99m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium99m";
        public override double halfLife { get; } = 21623.76d;
        public override double atomicWeight { get; } = 98.9064d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00869), new Technetium99() } },
            { 3.7000000000000005e-05d, new List<RadioactiveSubstance> { new BetaParticle(-1, 440200.0), new Ruthenium99() } },

        };
    }
}
    
    