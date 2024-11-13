
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium119";
        public override double halfLife { get; } = 0.92d;
        public override double atomicWeight { get; } = 118.92334d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver119() } },

        };
    }
}
    
    