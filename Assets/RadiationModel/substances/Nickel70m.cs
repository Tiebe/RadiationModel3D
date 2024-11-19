using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel70m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel70m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 69.9395d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00043, 2860900.0), new Nickel70() } },

        };
    }
}
    
    