
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium114";
        public override double halfLife { get; } = 0.121d;
        public override double atomicWeight { get; } = 113.93709d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium114() } },

        };
    }
}
    
    