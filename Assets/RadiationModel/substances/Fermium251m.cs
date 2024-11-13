
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium251m : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium251m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 251.08176d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Fermium251() } },

        };
    }
}
    
    