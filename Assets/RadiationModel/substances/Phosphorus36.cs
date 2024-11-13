
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus36 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus36";
        public override double halfLife { get; } = 5.6d;
        public override double atomicWeight { get; } = 35.97826d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sulfur36() } },

        };
    }
}
    
    