using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine88 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine88";
        public override double halfLife { get; } = 16.34d;
        public override double atomicWeight { get; } = 87.92408d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8975300.0), new Krypton88() } },

        };
    }
}
    
    