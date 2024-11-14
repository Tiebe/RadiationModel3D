using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium201 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium201";
        public override double halfLife { get; } = 21.0d;
        public override double atomicWeight { get; } = 200.9787d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3900000.0), new Platinum201() } },

        };
    }
}
    
    