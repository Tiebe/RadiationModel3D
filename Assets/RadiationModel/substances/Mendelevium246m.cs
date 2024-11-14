using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium246m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium246m";
        public override double halfLife { get; } = 4.4d;
        public override double atomicWeight { get; } = 246.08177d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.57d, new List<RadioactiveSubstance> { new AlphaParticle(9965047.4), new Einsteinium242() } },
            { 0.77d, new List<RadioactiveSubstance> { new BetaParticle(1, 5979000.0), new Fermium246() } },
            { 0.23d, new List<RadioactiveSubstance> { new AlphaParticle(9965047.4), new Einsteinium242() } },

        };
    }
}
    
    