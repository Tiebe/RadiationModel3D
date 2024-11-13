
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel69 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel69";
        public override double halfLife { get; } = 11.4d;
        public override double atomicWeight { get; } = 68.93561d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Copper69() } },

        };
    }
}
    
    