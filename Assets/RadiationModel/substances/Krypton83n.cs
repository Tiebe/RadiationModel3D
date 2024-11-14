using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton83n : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton83n";
        public override double halfLife { get; } = 6588.0d;
        public override double atomicWeight { get; } = 82.91417d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.02983), new Krypton83() } },

        };
    }
}
    
    