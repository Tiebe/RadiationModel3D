
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum184 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum184";
        public override double halfLife { get; } = 1038.0d;
        public override double atomicWeight { get; } = 183.95992d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iridium184() } },

            { 1.7e-05d, new List<RadioactiveSubstance> { new AlphaParticle(), new Osmium180() } },

        };
    }
}
    
    