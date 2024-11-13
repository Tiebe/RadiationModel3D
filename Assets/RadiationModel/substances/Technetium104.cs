
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium104";
        public override double halfLife { get; } = 1098.0d;
        public override double atomicWeight { get; } = 103.91143d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium104() } },

        };
    }
}
    
    