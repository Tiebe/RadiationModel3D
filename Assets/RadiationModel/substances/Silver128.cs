using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver128 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver128";
        public override double halfLife { get; } = 0.06d;
        public override double atomicWeight { get; } = 127.94127d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12528000.0), new Cadmium128() } },

        };
    }
}
    
    