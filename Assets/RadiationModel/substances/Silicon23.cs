using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon23 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon23";
        public override double halfLife { get; } = 0.0423d;
        public override double atomicWeight { get; } = 23.02571d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 17201900.0), new Aluminum23() } },

        };
    }
}
    
    