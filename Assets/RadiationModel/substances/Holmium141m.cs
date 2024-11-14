using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium141m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium141m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 140.96319d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Dysprosium140() } },

        };
    }
}
    
    