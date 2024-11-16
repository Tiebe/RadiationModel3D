using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper67 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper67";
        public override double halfLife { get; } = 222588.0d;
        public override double atomicWeight { get; } = 66.92773d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 560800.0), new Zinc67() } },

        };
    }
}
    
    