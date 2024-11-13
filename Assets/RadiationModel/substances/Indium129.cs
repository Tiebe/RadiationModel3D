
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium129";
        public override double halfLife { get; } = 0.57d;
        public override double atomicWeight { get; } = 128.92181d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin129() } },

        };
    }
}
    
    