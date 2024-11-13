
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium172";
        public override double halfLife { get; } = 4.4d;
        public override double atomicWeight { get; } = 171.97061d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.98d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium172() } },

            { 0.02d, new List<RadioactiveSubstance> { new AlphaParticle(), new Rhenium168() } },

        };
    }
}
    
    