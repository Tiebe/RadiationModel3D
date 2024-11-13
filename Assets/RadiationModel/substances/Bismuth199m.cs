
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

            { 0.02d, new List<RadioactiveSubstance> { new GammaParticle(), new Bismuth199() } },

            { 0.0001d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thallium195() } },

        };
    }
}
    
    