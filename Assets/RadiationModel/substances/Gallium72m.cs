using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium72m : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium72m";
        public override double halfLife { get; } = 0.03968d;
        public override double atomicWeight { get; } = 71.9265d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((119700.0, 0.01036)), new Gallium72() } },

        };
    }
}
    
    