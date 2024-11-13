
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine81m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine81m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 80.91686d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Bromine81() } },

        };
    }
}
    
    