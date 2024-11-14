using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium125n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium125n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 124.91583d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00062), new Indium125() } },

        };
    }
}
    
    