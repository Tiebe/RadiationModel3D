using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic76m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic76m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 75.92244d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((44400.00001, 0.02792)), new Arsenic76() } },

        };
    }
}
    
    