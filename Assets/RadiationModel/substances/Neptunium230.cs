using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium230";
        public override double halfLife { get; } = 276.0d;
        public override double atomicWeight { get; } = 230.03783d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.97d, new List<RadioactiveSubstance> { new BetaParticle(1, 3625000.0), new Uranium230() } },
            { 0.03d, new List<RadioactiveSubstance> { new AlphaParticle(7803002.09), new Protactinium226() } },

        };
    }
}
    
    