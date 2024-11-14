using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine94 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine94";
        public override double halfLife { get; } = 0.07d;
        public override double atomicWeight { get; } = 93.94885d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13698000.0), new Krypton94() } },

        };
    }
}
    
    