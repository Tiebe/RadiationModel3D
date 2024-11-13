
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium129";
        public override double halfLife { get; } = 0.55d;
        public override double atomicWeight { get; } = 128.95456d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Promethium129() } },

        };
    }
}
    
    