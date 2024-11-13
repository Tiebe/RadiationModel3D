
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum151 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum151";
        public override double halfLife { get; } = 0.465d;
        public override double atomicWeight { get; } = 150.94277d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium151() } },

        };
    }
}
    
    