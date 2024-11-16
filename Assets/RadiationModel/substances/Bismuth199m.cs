using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth199m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth199m";
        public override double halfLife { get; } = 1482.0d;
        public override double atomicWeight { get; } = 198.97839d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.02d, new List<RadioactiveSubstance> { new GammaParticle((667000.0, 0.00186)), new Bismuth199() } },
            { 0.0001d, new List<RadioactiveSubstance> { new AlphaParticle(6621002.09), new Thallium195() } },

        };
    }
}
    
    