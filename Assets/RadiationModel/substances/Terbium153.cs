using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium153";
        public override double halfLife { get; } = 202176.0d;
        public override double atomicWeight { get; } = 152.92344d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1568900.0), new Gadolinium153() } },

        };
    }
}
    
    