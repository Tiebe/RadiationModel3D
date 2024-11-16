using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum180n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum180n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 179.94903d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00085), new Tantalum180() } },

        };
    }
}
    
    