
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

            { 0.742d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead196() } },

            { 0.258d, new List<RadioactiveSubstance> { new GammaParticle(), new Bismuth196() } },

            { 3.8e-06d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thallium192() } },

        };
    }
}
    
    