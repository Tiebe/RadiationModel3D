using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium127";
        public override double halfLife { get; } = 0.028d;
        public override double atomicWeight { get; } = 126.96379d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13490000.0), new Palladium127() } },

        };
    }
}
    
    