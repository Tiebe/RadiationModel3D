using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium166m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium166m";
        public override double halfLife { get; } = 0.0151d;
        public override double atomicWeight { get; } = 165.9859d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.982d, new List<RadioactiveSubstance> { new AlphaParticle(7917002.09), new Rhenium162() } },
            { 0.018000000000000002d, new List<RadioactiveSubstance> { new ProtonParticle(), new Osmium165() } },

        };
    }
}
    
    