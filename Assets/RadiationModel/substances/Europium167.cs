using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium167";
        public override double halfLife { get; } = 1.33d;
        public override double atomicWeight { get; } = 166.95301d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7006000.0), new Gadolinium167() } },

        };
    }
}
    
    