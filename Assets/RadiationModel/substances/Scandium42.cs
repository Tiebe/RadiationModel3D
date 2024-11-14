using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium42 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium42";
        public override double halfLife { get; } = 0.68072d;
        public override double atomicWeight { get; } = 41.96552d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6426290.0), new Calcium42() } },

        };
    }
}
    
    