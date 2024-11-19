using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese52i : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese52i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 51.9487d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00042, 2926390.0), new Manganese52() } },

        };
    }
}
    
    