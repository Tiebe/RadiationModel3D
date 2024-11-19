using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium117m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium117m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 116.92638d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00386, 321000.0), new Rhodium117() } },

        };
    }
}
    
    