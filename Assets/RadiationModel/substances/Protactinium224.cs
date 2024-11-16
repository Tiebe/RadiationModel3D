using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium224";
        public override double halfLife { get; } = 0.844d;
        public override double atomicWeight { get; } = 224.02562d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8713047.4), new Actinium220() } },

        };
    }
}
    
    