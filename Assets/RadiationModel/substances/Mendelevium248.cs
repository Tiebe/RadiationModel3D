
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium248";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 248.08261d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.8d, new List<RadioactiveSubstance> { new BetaParticle(), new Fermium248() } },

            { 0.2d, new List<RadioactiveSubstance> { new AlphaParticle(), new Einsteinium244() } },

        };
    }
}
    
    