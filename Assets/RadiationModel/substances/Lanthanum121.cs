
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum121 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum121";
        public override double halfLife { get; } = 5.3d;
        public override double atomicWeight { get; } = 120.93324d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium121() } },

        };
    }
}
    
    