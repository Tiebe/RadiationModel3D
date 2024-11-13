
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon221 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon221";
        public override double halfLife { get; } = 1542.0d;
        public override double atomicWeight { get; } = 221.01554d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.78d, new List<RadioactiveSubstance> { new BetaParticle(), new Francium221() } },

            { 0.22d, new List<RadioactiveSubstance> { new AlphaParticle(), new Polonium217() } },

        };
    }
}
    
    