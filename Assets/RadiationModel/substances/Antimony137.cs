
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony137 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony137";
        public override double halfLife { get; } = 0.497d;
        public override double atomicWeight { get; } = 136.93552d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tellurium137() } },

        };
    }
}
    
    