using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium161m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium161m";
        public override double halfLife { get; } = 0.0073d;
        public override double atomicWeight { get; } = 160.94377d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00681, 182000.0), new Lutetium161() } },

        };
    }
}
    
    