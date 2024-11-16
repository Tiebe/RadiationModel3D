using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver127 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver127";
        public override double halfLife { get; } = 0.089d;
        public override double atomicWeight { get; } = 126.93704d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10091000.0), new Cadmium127() } },

        };
    }
}
    
    