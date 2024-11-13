
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium112";
        public override double halfLife { get; } = 75744.0d;
        public override double atomicWeight { get; } = 111.90733d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver112() } },

        };
    }
}
    
    