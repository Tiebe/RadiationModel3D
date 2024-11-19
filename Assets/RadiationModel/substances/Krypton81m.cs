using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton81m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton81m";
        public override double halfLife { get; } = 13.1d;
        public override double atomicWeight { get; } = 80.91679d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((190600.00001, 0.0065)), new Krypton81() } },
            { 2.5e-05d, new List<RadioactiveSubstance> { new Bromine81() } },

        };
    }
}
    
    