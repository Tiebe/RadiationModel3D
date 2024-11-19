using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium166n : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium166n";
        public override double halfLife { get; } = 0.00018d;
        public override double atomicWeight { get; } = 165.9325d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((190900.00001, 0.00649)), new Holmium166() } },

        };
    }
}
    
    