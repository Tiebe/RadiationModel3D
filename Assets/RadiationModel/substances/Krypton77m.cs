using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton77m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton77m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 76.92474d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01864, 66500.0), new Krypton77() } },

        };
    }
}
    
    