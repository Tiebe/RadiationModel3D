
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine126 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine126";
        public override double halfLife { get; } = 1117152.0d;
        public override double atomicWeight { get; } = 125.90562d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.527d, new List<RadioactiveSubstance> { new BetaParticle(), new Tellurium126() } },

            { 0.473d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon126() } },

        };
    }
}
    
    