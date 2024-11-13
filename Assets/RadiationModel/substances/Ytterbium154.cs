
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium154";
        public override double halfLife { get; } = 0.409d;
        public override double atomicWeight { get; } = 153.9464d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9259999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(), new Erbium150() } },

            { 0.07400000000000001d, new List<RadioactiveSubstance> { new BetaParticle(), new Thulium154() } },

        };
    }
}
    
    