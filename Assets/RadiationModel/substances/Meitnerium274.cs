using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium274 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium274";
        public override double halfLife { get; } = 0.85d;
        public override double atomicWeight { get; } = 274.14734d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11617002.09), new Bohrium270() } },

        };
    }
}
    
    