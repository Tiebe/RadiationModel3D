
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver117m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver117m";
        public override double halfLife { get; } = 5.34d;
        public override double atomicWeight { get; } = 116.91181d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.94d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium117() } },

            { 0.06d, new List<RadioactiveSubstance> { new GammaParticle(), new Silver117() } },

        };
    }
}
    
    