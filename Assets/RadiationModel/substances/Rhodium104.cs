using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium104";
        public override double halfLife { get; } = 42.3d;
        public override double atomicWeight { get; } = 103.90665d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9954999999999999d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2435800.0), new Palladium104() } },
            { 0.0045000000000000005d, new List<RadioactiveSubstance> { new BetaParticle(1, 1136500.0), new Ruthenium104() } },

        };
    }
}
    
    