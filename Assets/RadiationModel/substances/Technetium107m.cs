using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium107m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium107m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 106.91549d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.04133), new Technetium107() } },

        };
    }
}
    
    