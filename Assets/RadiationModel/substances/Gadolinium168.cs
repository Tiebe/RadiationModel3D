
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium168";
        public override double halfLife { get; } = 3.03d;
        public override double atomicWeight { get; } = 167.94831d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium168() } },

        };
    }
}
    
    