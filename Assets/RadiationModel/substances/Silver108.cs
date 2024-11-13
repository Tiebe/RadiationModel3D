
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver108 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver108";
        public override double halfLife { get; } = 142.92d;
        public override double atomicWeight { get; } = 107.90595d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9715d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium108() } },

            { 0.0285d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium108() } },

        };
    }
}
    
    