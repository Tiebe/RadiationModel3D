using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium208m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium208m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 207.98289d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1528199.99999, 0.00081)), new Polonium208() } },

        };
    }
}
    
    