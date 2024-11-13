
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium181p : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium181p";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 180.95208d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Rhenium181() } },

        };
    }
}
    
    