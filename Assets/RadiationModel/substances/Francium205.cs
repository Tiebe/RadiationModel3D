using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium205 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium205";
        public override double halfLife { get; } = 3.9d;
        public override double atomicWeight { get; } = 204.99859d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.985d, new List<RadioactiveSubstance> { new AlphaParticle(8074047.4), new Astatine201() } },
            { 0.015d, new List<RadioactiveSubstance> { new BetaParticle(1, 6400000.0), new Radon205() } },

        };
    }
}
    
    