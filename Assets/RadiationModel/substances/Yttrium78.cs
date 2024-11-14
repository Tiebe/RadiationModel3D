using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium78 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium78";
        public override double halfLife { get; } = 0.054d;
        public override double atomicWeight { get; } = 77.94399d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11004000.0), new Strontium78() } },

        };
    }
}
    
    