using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth201 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth201";
        public override double halfLife { get; } = 6180.0d;
        public override double atomicWeight { get; } = 200.977d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3842000.0), new Lead201() } },

        };
    }
}
    
    