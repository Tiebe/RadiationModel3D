
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver100 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver100";
        public override double halfLife { get; } = 120.6d;
        public override double atomicWeight { get; } = 99.91612d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium100() } },

        };
    }
}
    
    