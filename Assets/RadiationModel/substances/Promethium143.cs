
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium143";
        public override double halfLife { get; } = 22896000.0d;
        public override double atomicWeight { get; } = 142.91094d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Neodymium143() } },

            { 5.6999999999999994e-08d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium143() } },

        };
    }
}
    
    