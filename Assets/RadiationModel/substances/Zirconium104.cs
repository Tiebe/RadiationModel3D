using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium104";
        public override double halfLife { get; } = 0.92d;
        public override double atomicWeight { get; } = 103.92945d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6093000.0), new Niobium104() } },

        };
    }
}
    
    