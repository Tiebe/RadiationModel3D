using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium46m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium46m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 45.95522d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.02384), new Scandium46() } },

        };
    }
}
    
    