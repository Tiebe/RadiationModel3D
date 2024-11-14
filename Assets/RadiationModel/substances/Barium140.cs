using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium140";
        public override double halfLife { get; } = 1101893.76d;
        public override double atomicWeight { get; } = 139.91061d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1044099.9999999999), new Lanthanum140() } },

        };
    }
}
    
    