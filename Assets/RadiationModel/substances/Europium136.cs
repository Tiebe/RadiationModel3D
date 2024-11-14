using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium136";
        public override double halfLife { get; } = 3.3d;
        public override double atomicWeight { get; } = 135.93962d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10571000.0), new Samarium136() } },

        };
    }
}
    
    