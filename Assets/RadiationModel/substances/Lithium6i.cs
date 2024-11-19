using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lithium6i : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium6i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 6.01895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00035, 3562879.6), new Lithium6() } },

        };
    }
}
    
    