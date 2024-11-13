
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony129m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony129m";
        public override double halfLife { get; } = 1062.0d;
        public override double atomicWeight { get; } = 128.91113d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.85d, new List<RadioactiveSubstance> { new BetaParticle(), new Tellurium129() } },

            { 0.15d, new List<RadioactiveSubstance> { new GammaParticle(), new Antimony129() } },

        };
    }
}
    
    