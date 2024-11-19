using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium153m";
        public override double halfLife { get; } = 0.0106d;
        public override double atomicWeight { get; } = 152.92221d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0126, 98400.0), new Samarium153() } },

        };
    }
}
    
    