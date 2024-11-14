using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium146m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium146m";
        public override double halfLife { get; } = 0.15d;
        public override double atomicWeight { get; } = 145.93599d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00042), new Dysprosium146() } },

        };
    }
}
    
    