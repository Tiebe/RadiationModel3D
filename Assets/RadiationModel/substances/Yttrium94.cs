
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium94";
        public override double halfLife { get; } = 1122.0d;
        public override double atomicWeight { get; } = 93.91159d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium94() } },

        };
    }
}
    
    