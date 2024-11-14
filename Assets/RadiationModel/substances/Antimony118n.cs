using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony118n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony118n";
        public override double halfLife { get; } = 18036.0d;
        public override double atomicWeight { get; } = 117.9058d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3906800.0), new Tin118() } },

        };
    }
}
    
    