
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium194 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium194";
        public override double halfLife { get; } = 189341712.0d;
        public override double atomicWeight { get; } = 193.96518d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iridium194() } },

        };
    }
}
    
    