using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium138m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium138m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 137.90749d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00059, 2090540.0), new Barium138() } },

        };
    }
}
    
    