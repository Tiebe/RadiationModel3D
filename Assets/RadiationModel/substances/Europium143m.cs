using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium143m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium143m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 142.92072d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00318, 390000.0), new Europium143() } },

        };
    }
}
    
    