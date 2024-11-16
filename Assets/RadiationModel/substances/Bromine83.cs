using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine83 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine83";
        public override double halfLife { get; } = 8546.4d;
        public override double atomicWeight { get; } = 82.91517d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 976643.0), new Krypton83() } },

        };
    }
}
    
    