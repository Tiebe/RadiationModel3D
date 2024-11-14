using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium236";
        public override double halfLife { get; } = 2238.0d;
        public override double atomicWeight { get; } = 236.04966d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 921000.0), new Protactinium236() } },

        };
    }
}
    
    