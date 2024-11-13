
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur30 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur30";
        public override double halfLife { get; } = 1.1798d;
        public override double atomicWeight { get; } = 29.98491d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Phosphorus30() } },

        };
    }
}
    
    