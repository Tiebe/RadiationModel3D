
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum135 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum135";
        public override double halfLife { get; } = 68076.0d;
        public override double atomicWeight { get; } = 134.90698d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium135() } },

        };
    }
}
    
    