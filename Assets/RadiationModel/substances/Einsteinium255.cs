
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium255";
        public override double halfLife { get; } = 3438720.0d;
        public override double atomicWeight { get; } = 255.09027d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.92d, new List<RadioactiveSubstance> { new BetaParticle(), new Fermium255() } },

            { 0.08d, new List<RadioactiveSubstance> { new AlphaParticle(), new Berkelium251() } },

            { 4.1e-05d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    