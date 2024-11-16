using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium213m : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium213m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 213.01428d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00105), new Thorium213() } },

        };
    }
}
    
    