using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin133 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin133";
        public override double halfLife { get; } = 1.37d;
        public override double atomicWeight { get; } = 132.92391d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8050100.0), new Antimony133() } },

        };
    }
}
    
    