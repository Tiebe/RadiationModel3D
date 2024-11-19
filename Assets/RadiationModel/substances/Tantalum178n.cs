using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum178n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum178n";
        public override double halfLife { get; } = 0.059d;
        public override double atomicWeight { get; } = 177.94726d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1470000.0, 0.00084)), new Tantalum178() } },

        };
    }
}
    
    