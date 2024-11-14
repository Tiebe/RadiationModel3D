using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium168";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 167.95786d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8900000.0), new Gadolinium168() } },

        };
    }
}
    
    