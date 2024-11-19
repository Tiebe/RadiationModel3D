using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium167";
        public override double halfLife { get; } = 0.0293d;
        public override double atomicWeight { get; } = 166.98167d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.435d, new List<RadioactiveSubstance> { new AlphaParticle(7527002.09), new Rhenium163() } },
            { 0.386d, new List<RadioactiveSubstance> { new ProtonParticle(), new Osmium166() } },

        };
    }
}
    
    