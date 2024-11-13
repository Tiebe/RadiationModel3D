
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver126 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver126";
        public override double halfLife { get; } = 0.052d;
        public override double atomicWeight { get; } = 125.93481d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium126() } },

        };
    }
}
    
    