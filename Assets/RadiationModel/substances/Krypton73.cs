using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton73 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton73";
        public override double halfLife { get; } = 27.3d;
        public override double atomicWeight { get; } = 72.93929d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7094000.0), new Bromine73() } },

        };
    }
}
    
    