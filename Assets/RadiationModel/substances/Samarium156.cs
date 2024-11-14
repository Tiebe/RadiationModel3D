using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium156";
        public override double halfLife { get; } = 33840.0d;
        public override double atomicWeight { get; } = 155.92554d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 722000.0), new Europium156() } },

        };
    }
}
    
    