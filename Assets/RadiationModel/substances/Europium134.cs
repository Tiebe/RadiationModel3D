
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium134";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 133.94654d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium134() } },

        };
    }
}
    
    