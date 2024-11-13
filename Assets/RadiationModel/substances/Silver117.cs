
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver117 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver117";
        public override double halfLife { get; } = 73.6d;
        public override double atomicWeight { get; } = 116.91177d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium117() } },

        };
    }
}
    
    