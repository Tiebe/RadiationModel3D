
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc73m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc73m";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 72.92979d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Zinc73() } },

        };
    }
}
    
    