
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium104";
        public override double halfLife { get; } = 3462.0d;
        public override double atomicWeight { get; } = 103.90986d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver104() } },

        };
    }
}
    
    