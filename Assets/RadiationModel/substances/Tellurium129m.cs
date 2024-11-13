
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium129m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium129m";
        public override double halfLife { get; } = 2903040.0d;
        public override double atomicWeight { get; } = 128.90671d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.64d, new List<RadioactiveSubstance> { new GammaParticle(), new Tellurium129() } },

            { 0.36d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine129() } },

        };
    }
}
    
    