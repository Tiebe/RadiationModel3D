using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper68 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper68";
        public override double halfLife { get; } = 30.9d;
        public override double atomicWeight { get; } = 67.92961d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4440200.0), new Zinc68() } },

        };
    }
}
    
    