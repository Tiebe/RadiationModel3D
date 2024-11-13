
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

            { 0.9987d, new List<RadioactiveSubstance> { new GammaParticle(), new Rhodium104() } },

            { 0.0013d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium104() } },

        };
    }
}
    
    