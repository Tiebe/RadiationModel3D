using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium152m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium152m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 151.93168d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((115000.0, 0.01078)), new Praseodymium152() } },

        };
    }
}
    
    