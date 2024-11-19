using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth196n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth196n";
        public override double halfLife { get; } = 240.0d;
        public override double atomicWeight { get; } = 195.98096d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.742d, new List<RadioactiveSubstance> { new BetaParticle(1, 7611000.0), new Lead196() } },
            { 0.258d, new List<RadioactiveSubstance> { new GammaParticle((272000.0, 0.00456)), new Bismuth196() } },
            { 3.8e-06d, new List<RadioactiveSubstance> { new AlphaParticle(6730002.09), new Thallium192() } },

        };
    }
}
    
    