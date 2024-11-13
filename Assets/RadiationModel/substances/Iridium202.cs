
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium202 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium202";
        public override double halfLife { get; } = 11.0d;
        public override double atomicWeight { get; } = 201.98214d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum202() } },

        };
    }
}
    
    