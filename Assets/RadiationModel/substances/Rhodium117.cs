
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium117";
        public override double halfLife { get; } = 0.421d;
        public override double atomicWeight { get; } = 116.92604d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium117() } },

        };
    }
}
    
    