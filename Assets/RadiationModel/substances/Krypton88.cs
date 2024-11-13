
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton88 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton88";
        public override double halfLife { get; } = 10170.0d;
        public override double atomicWeight { get; } = 87.91445d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rubidium88() } },

        };
    }
}
    
    