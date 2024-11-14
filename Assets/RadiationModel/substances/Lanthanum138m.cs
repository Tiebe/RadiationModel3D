using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum138m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum138m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 137.9072d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01708), new Lanthanum138() } },

        };
    }
}
    
    