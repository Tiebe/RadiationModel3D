
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium168";
        public override double halfLife { get; } = 179.4d;
        public override double atomicWeight { get; } = 167.93552d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium168() } },

        };
    }
}
    
    