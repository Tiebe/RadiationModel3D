using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium216p : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium216p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 216.01501d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00034), new Thorium216() } },

        };
    }
}
    
    