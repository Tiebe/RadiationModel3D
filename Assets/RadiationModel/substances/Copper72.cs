
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper72 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper72";
        public override double halfLife { get; } = 6.63d;
        public override double atomicWeight { get; } = 71.93582d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zinc72() } },

        };
    }
}
    
    