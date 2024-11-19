using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin128m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin128m";
        public override double halfLife { get; } = 6.5d;
        public override double atomicWeight { get; } = 127.91275d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2091000.0, 0.00059)), new Tin128() } },

        };
    }
}
    
    