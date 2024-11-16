using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium121n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium121n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 120.91058d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2545000.0, 0.00049)), new Indium121() } },

        };
    }
}
    
    