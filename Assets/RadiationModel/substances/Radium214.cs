using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium214";
        public override double halfLife { get; } = 2.437d;
        public override double atomicWeight { get; } = 214.0001d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99941d, new List<RadioactiveSubstance> { new AlphaParticle(8295002.09), new Radon210() } },
            { 0.0005899999999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 1051000.0), new Francium214() } },

        };
    }
}
    
    