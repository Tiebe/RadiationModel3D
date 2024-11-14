using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium127";
        public override double halfLife { get; } = 0.48d;
        public override double atomicWeight { get; } = 126.9262d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8139000.0), new Indium127() } },

        };
    }
}
    
    