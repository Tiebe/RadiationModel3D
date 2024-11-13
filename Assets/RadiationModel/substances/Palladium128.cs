
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium128";
        public override double halfLife { get; } = 0.035d;
        public override double atomicWeight { get; } = 127.95235d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver128() } },

        };
    }
}
    
    