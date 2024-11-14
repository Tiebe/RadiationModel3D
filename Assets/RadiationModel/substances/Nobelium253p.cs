using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium253p : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium253p";
        public override double halfLife { get; } = 0.00055d;
        public override double atomicWeight { get; } = 253.09192d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00098), new Nobelium253() } },

        };
    }
}
    
    