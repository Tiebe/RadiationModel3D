
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium143";
        public override double halfLife { get; } = 525.0d;
        public override double atomicWeight { get; } = 142.91463d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Promethium143() } },

            { 0.4d, new List<RadioactiveSubstance> { new BetaParticle(), new Promethium143() } },

            { 0.6d, new List<RadioactiveSubstance> { new Promethium143() } },

        };
    }
}
    
    