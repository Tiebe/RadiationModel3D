
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium153m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 152.9522d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Ytterbium153() } },

        };
    }
}
    
    