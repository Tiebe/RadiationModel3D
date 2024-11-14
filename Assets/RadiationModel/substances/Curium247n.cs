using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium247n : RadioactiveSubstance
    {
        public override string name { get; } = "Curium247n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 247.07079d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00306), new Curium247() } },

        };
    }
}
    
    