
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon111 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon111";
        public override double halfLife { get; } = 0.74d;
        public override double atomicWeight { get; } = 110.94147d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.8959999999999999d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine111() } },

            { 0.10400000000000001d, new List<RadioactiveSubstance> { new AlphaParticle(), new Tellurium107() } },

        };
    }
}
    
    