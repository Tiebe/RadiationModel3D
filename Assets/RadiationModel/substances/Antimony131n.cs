using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony131n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony131n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 130.9138d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00073, 1687200.0), new Antimony131() } },

        };
    }
}
    
    