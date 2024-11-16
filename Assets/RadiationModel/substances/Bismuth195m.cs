using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth195m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth195m";
        public override double halfLife { get; } = 87.0d;
        public override double atomicWeight { get; } = 194.98108d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.67d, new List<RadioactiveSubstance> { new BetaParticle(1, 6112000.0), new Lead195() } },
            { 0.33d, new List<RadioactiveSubstance> { new AlphaParticle(7254002.09), new Thallium191() } },

        };
    }
}
    
    