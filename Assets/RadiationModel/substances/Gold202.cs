using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold202 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold202";
        public override double halfLife { get; } = 28.4d;
        public override double atomicWeight { get; } = 201.97386d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2992300.0), new Mercury202() } },

        };
    }
}
    
    