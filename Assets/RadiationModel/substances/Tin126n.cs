using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin126n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin126n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 125.91041d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00048, 2564000.0), new Tin126() } },

        };
    }
}
    
    