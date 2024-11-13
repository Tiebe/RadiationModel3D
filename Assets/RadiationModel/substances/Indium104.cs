
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium104";
        public override double halfLife { get; } = 108.0d;
        public override double atomicWeight { get; } = 103.91821d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium104() } },

        };
    }
}
    
    