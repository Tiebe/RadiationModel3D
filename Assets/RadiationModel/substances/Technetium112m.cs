using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium112m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium112m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 111.93032d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00352, 352000.0), new Technetium112() } },

        };
    }
}
    
    