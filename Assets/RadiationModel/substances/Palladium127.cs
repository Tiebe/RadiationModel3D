using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium127";
        public override double halfLife { get; } = 0.038d;
        public override double atomicWeight { get; } = 126.94931d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11430000.0), new Silver127() } },

        };
    }
}
    
    