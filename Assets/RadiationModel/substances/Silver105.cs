using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver105 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver105";
        public override double halfLife { get; } = 3567456.0d;
        public override double atomicWeight { get; } = 104.90653d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1346900.0), new Palladium105() } },

        };
    }
}
    
    