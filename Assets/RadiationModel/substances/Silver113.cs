
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver113 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver113";
        public override double halfLife { get; } = 19332.0d;
        public override double atomicWeight { get; } = 112.90657d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium113() } },

        };
    }
}
    
    