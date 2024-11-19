using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth196 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth196";
        public override double halfLife { get; } = 307.8d;
        public override double atomicWeight { get; } = 195.98067d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7339000.0), new Lead196() } },
            { 1.15e-05d, new List<RadioactiveSubstance> { new AlphaParticle(6458002.09), new Thallium192() } },

        };
    }
}
    
    