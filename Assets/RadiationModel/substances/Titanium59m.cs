using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium59m : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium59m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 58.97233d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01127, 110000.0), new Titanium59() } },

        };
    }
}
    
    