
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver114 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver114";
        public override double halfLife { get; } = 4.6d;
        public override double atomicWeight { get; } = 113.90882d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium114() } },

        };
    }
}
    
    