using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum136m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum136m";
        public override double halfLife { get; } = 0.114d;
        public override double atomicWeight { get; } = 135.90791d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00477), new Lanthanum136() } },

        };
    }
}
    
    