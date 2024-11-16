using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium132n : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium132n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 131.91061d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1925000.0, 0.00064)), new Tellurium132() } },

        };
    }
}
    
    