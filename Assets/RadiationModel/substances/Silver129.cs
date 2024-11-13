
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver129 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver129";
        public override double halfLife { get; } = 0.0499d;
        public override double atomicWeight { get; } = 128.94432d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium129() } },

        };
    }
}
    
    