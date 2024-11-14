using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium160";
        public override double halfLife { get; } = 9.6d;
        public override double atomicWeight { get; } = 159.93534d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3260200.0), new Europium160() } },

        };
    }
}
    
    