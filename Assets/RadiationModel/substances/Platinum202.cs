using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum202 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum202";
        public override double halfLife { get; } = 158400.0d;
        public override double atomicWeight { get; } = 201.97564d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1661000.0), new Gold202() } },

        };
    }
}
    
    