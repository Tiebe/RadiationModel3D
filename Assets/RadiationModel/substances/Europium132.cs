using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium132";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 131.9547d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Samarium131() } },

        };
    }
}
    
    