
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese70 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese70";
        public override double halfLife { get; } = 0.0199d;
        public override double atomicWeight { get; } = 69.97805d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron70() } },

        };
    }
}
    
    