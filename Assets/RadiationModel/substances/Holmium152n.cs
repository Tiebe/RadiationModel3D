using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium152n : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium152n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 151.93496d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00041), new Holmium152() } },

        };
    }
}
    
    