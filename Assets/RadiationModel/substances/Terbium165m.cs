using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium165m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium165m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 164.93518d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.006, 206800.0), new Terbium165() } },

        };
    }
}
    
    