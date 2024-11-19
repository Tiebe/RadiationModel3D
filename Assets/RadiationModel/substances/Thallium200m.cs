using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium200m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium200m";
        public override double halfLife { get; } = 0.034d;
        public override double atomicWeight { get; } = 199.97177d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00164, 754000.0), new Thallium200() } },

        };
    }
}
    
    