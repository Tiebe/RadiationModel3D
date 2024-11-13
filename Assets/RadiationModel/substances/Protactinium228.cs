
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium228";
        public override double halfLife { get; } = 79200.0d;
        public override double atomicWeight { get; } = 228.03105d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9815d, new List<RadioactiveSubstance> { new BetaParticle(), new Thorium228() } },

            { 0.018500000000000003d, new List<RadioactiveSubstance> { new AlphaParticle(), new Actinium224() } },

        };
    }
}
    
    