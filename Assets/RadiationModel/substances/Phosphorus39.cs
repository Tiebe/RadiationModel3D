
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus39 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus39";
        public override double halfLife { get; } = 0.282d;
        public override double atomicWeight { get; } = 38.98629d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sulfur39() } },

        };
    }
}
    
    