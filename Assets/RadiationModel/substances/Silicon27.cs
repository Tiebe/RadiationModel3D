using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon27 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon27";
        public override double halfLife { get; } = 4.117d;
        public override double atomicWeight { get; } = 26.9867d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4812350.0), new Aluminum27() } },

        };
    }
}
    
    