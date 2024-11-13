
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium230";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 230.04602d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Plutonium230() } },

        };
    }
}
    
    