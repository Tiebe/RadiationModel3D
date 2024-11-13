
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium143";
        public override double halfLife { get; } = 155.4d;
        public override double atomicWeight { get; } = 142.9203d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium143() } },

        };
    }
}
    
    