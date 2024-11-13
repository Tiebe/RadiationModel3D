
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium149m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium149m";
        public override double halfLife { get; } = 8.9d;
        public override double atomicWeight { get; } = 148.9431d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.965d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium149() } },

            { 0.035d, new List<RadioactiveSubstance> { new GammaParticle(), new Erbium149() } },

        };
    }
}
    
    