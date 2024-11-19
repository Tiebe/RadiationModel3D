using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium97n : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium97n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 96.92727d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((831000.0, 0.00149)), new Strontium97() } },

        };
    }
}
    
    