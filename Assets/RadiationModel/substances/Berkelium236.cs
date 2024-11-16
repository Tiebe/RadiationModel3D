using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium236";
        public override double halfLife { get; } = 26.0d;
        public override double atomicWeight { get; } = 236.05748d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5687000.0), new Curium236() } },

        };
    }
}
    
    