using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic66m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic66m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 65.94561d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00091), new Arsenic66() } },

        };
    }
}
    
    