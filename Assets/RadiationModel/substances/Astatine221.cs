
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine221 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine221";
        public override double halfLife { get; } = 138.0d;
        public override double atomicWeight { get; } = 221.01802d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Radon221() } },

        };
    }
}
    
    