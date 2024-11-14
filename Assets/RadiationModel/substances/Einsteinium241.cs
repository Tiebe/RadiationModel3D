using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium241";
        public override double halfLife { get; } = 5.1d;
        public override double atomicWeight { get; } = 241.06859d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9275047.4), new Berkelium237() } },

        };
    }
}
    
    