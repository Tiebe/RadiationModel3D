
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver96m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver96m";
        public override double halfLife { get; } = 6.9d;
        public override double atomicWeight { get; } = 95.93075d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium96() } },

        };
    }
}
    
    