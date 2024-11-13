
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin129 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin129";
        public override double halfLife { get; } = 133.8d;
        public override double atomicWeight { get; } = 128.91348d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony129() } },

        };
    }
}
    
    