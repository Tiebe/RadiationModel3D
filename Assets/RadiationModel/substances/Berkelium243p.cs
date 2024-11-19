using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium243p : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium243p";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 243.06303d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.06199, 20000.0), new Berkelium243() } },

        };
    }
}
    
    