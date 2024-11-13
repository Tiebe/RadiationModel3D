
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium105";
        public override double halfLife { get; } = 458.4d;
        public override double atomicWeight { get; } = 104.91166d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium105() } },

        };
    }
}
    
    