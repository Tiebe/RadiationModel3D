using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium103m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium103m";
        public override double halfLife { get; } = 3366.84d;
        public override double atomicWeight { get; } = 102.90554d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.03115), new Rhodium103() } },

        };
    }
}
    
    