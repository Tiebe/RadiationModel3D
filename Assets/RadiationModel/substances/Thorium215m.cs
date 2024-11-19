using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium215m : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium215m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 215.0133d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00084, 1469000.0), new Thorium215() } },

        };
    }
}
    
    