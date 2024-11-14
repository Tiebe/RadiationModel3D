using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium105m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium105m";
        public override double halfLife { get; } = 48.0d;
        public override double atomicWeight { get; } = 104.91523d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00184), new Indium105() } },

        };
    }
}
    
    