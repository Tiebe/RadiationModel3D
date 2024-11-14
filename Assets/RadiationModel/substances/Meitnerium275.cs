using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium275 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium275";
        public override double halfLife { get; } = 0.031d;
        public override double atomicWeight { get; } = 275.14898d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11505047.4), new Bohrium271() } },

        };
    }
}
    
    