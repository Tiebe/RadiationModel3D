using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic75m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic75m";
        public override double halfLife { get; } = 0.01762d;
        public override double atomicWeight { get; } = 74.92192d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00408), new Arsenic75() } },

        };
    }
}
    
    