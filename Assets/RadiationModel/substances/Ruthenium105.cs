
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium105";
        public override double halfLife { get; } = 15980.4d;
        public override double atomicWeight { get; } = 104.90775d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhodium105() } },

        };
    }
}
    
    