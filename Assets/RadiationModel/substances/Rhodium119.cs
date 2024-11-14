using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium119";
        public override double halfLife { get; } = 0.19d;
        public override double atomicWeight { get; } = 118.93256d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8584000.0), new Palladium119() } },

        };
    }
}
    
    