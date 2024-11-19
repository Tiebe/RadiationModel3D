using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium253n : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium253n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 253.08556d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00353, 351500.0), new Fermium253() } },

        };
    }
}
    
    