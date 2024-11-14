using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium189 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium189";
        public override double halfLife { get; } = 87480.0d;
        public override double atomicWeight { get; } = 188.95923d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1007800.0), new Osmium189() } },

        };
    }
}
    
    