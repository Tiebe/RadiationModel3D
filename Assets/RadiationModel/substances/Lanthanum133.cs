
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum133 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum133";
        public override double halfLife { get; } = 14083.2d;
        public override double atomicWeight { get; } = 132.90822d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium133() } },

        };
    }
}
    
    