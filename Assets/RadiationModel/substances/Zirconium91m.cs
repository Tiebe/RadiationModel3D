using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium91m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium91m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 90.90904d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00039, 3167290.0), new Zirconium91() } },

        };
    }
}
    
    