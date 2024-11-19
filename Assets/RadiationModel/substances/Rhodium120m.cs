using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium120m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium120m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 119.93724d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00775, 160000.0), new Rhodium120() } },

        };
    }
}
    
    