
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium119m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium119m";
        public override double halfLife { get; } = 1080.0d;
        public override double atomicWeight { get; } = 118.90619d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9740000000000001d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin119() } },

            { 0.026000000000000002d, new List<RadioactiveSubstance> { new GammaParticle(), new Indium119() } },

        };
    }
}
    
    