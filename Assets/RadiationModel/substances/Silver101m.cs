
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver101m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver101m";
        public override double halfLife { get; } = 3.1d;
        public override double atomicWeight { get; } = 100.91298d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Silver101() } },

        };
    }
}
    
    