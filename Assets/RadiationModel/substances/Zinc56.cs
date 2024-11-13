
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc56 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc56";
        public override double halfLife { get; } = 0.0324d;
        public override double atomicWeight { get; } = 55.97274d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Copper56() } },

        };
    }
}
    
    