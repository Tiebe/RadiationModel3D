using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum26 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum26";
        public override double halfLife { get; } = 22626334584000.0d;
        public override double atomicWeight { get; } = 25.98689d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4004404.0), new Magnesium26() } },

        };
    }
}
    
    