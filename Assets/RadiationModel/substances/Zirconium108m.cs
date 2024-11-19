using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium108m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium108m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 107.94753d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2070000.0, 0.0006)), new Zirconium108() } },

        };
    }
}
    
    