using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium162m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 161.92915d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00057, 2188100.0), new Dysprosium162() } },

        };
    }
}
    
    