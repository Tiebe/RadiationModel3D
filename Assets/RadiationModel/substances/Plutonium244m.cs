using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium244m : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium244m";
        public override double halfLife { get; } = 1.75d;
        public override double atomicWeight { get; } = 244.06551d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1216000.0, 0.00102)), new Plutonium244() } },

        };
    }
}
    
    