
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium237";
        public override double halfLife { get; } = 288.0d;
        public override double atomicWeight { get; } = 237.05363d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Protactinium237() } },

        };
    }
}
    
    