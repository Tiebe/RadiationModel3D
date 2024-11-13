
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic73m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic73m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 72.92429d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Arsenic73() } },

        };
    }
}
    
    