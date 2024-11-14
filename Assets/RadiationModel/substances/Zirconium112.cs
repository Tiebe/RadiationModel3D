using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium112";
        public override double halfLife { get; } = 0.043d;
        public override double atomicWeight { get; } = 111.9652d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11650000.0), new Niobium112() } },

        };
    }
}
    
    