
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium151";
        public override double halfLife { get; } = 23.5d;
        public override double atomicWeight { get; } = 150.93745d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium151() } },

        };
    }
}
    
    