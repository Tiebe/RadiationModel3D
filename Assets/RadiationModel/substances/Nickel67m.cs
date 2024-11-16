using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel67m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel67m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 66.93265d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00123), new Nickel67() } },

        };
    }
}
    
    