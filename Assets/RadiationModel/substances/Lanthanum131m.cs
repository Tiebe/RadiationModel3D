using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum131m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum131m";
        public override double halfLife { get; } = 0.00017d;
        public override double atomicWeight { get; } = 130.9104d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00407, 305000.0), new Lanthanum131() } },

        };
    }
}
    
    