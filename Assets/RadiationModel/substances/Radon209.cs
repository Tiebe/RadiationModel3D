using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon209 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon209";
        public override double halfLife { get; } = 1728.0d;
        public override double atomicWeight { get; } = 208.9904d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new List<RadioactiveSubstance> { new BetaParticle(1, 3943000.0), new Astatine209() } },
            { 0.17d, new List<RadioactiveSubstance> { new AlphaParticle(7175047.4), new Polonium205() } },

        };
    }
}
    
    