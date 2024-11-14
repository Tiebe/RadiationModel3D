using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium134";
        public override double halfLife { get; } = 9.5d;
        public override double atomicWeight { get; } = 133.93411d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5380000.0), new Promethium134() } },

        };
    }
}
    
    