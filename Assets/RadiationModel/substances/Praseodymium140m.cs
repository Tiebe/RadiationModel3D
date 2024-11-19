using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium140m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium140m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 139.90922d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00969, 128000.0), new Praseodymium140() } },

        };
    }
}
    
    