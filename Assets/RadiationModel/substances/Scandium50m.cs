
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium50m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium50m";
        public override double halfLife { get; } = 0.35d;
        public override double atomicWeight { get; } = 49.95246d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.99d, new List<RadioactiveSubstance> { new GammaParticle(), new Scandium50() } },

            { 0.01d, new List<RadioactiveSubstance> { new BetaParticle(), new Titanium50() } },

        };
    }
}
    
    