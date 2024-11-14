using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium88";
        public override double halfLife { get; } = 9212745.6d;
        public override double atomicWeight { get; } = 87.9095d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3622629.0), new Strontium88() } },

        };
    }
}
    
    