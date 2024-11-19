using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium104m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium104m";
        public override double halfLife { get; } = 260.4d;
        public override double atomicWeight { get; } = 103.90678d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9987d, new List<RadioactiveSubstance> { new GammaParticle((129000.0, 0.00961)), new Rhodium104() } },
            { 0.0013d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2564800.0), new Palladium104() } },

        };
    }
}
    
    