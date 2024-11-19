using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium250m : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium250m";
        public override double halfLife { get; } = 1.92d;
        public override double atomicWeight { get; } = 250.08081d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00103, 1199000.0), new Fermium250() } },

        };
    }
}
    
    