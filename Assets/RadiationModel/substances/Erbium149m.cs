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
            { 0.965d, new List<RadioactiveSubstance> { new BetaParticle(1, 8646000.0), new Holmium149() } },
            { 0.035d, new List<RadioactiveSubstance> { new GammaParticle(0.00167, 742000.0), new Erbium149() } },

        };
    }
}
    
    