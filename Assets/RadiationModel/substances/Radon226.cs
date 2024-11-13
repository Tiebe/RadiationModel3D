
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon226 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon226";
        public override double halfLife { get; } = 444.0d;
        public override double atomicWeight { get; } = 226.03086d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Francium226() } },

        };
    }
}
    
    