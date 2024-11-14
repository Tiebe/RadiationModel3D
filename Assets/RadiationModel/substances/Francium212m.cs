using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium212m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium212m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 211.99789d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0008), new Francium212() } },

        };
    }
}
    
    