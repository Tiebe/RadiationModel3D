using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium135";
        public override double halfLife { get; } = 63720.0d;
        public override double atomicWeight { get; } = 134.90916d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2027000.0), new Lanthanum135() } },

        };
    }
}
    
    