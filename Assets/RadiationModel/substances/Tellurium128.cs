
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium128";
        public override double halfLife { get; } = 7.1003142e+31d;
        public override double atomicWeight { get; } = 127.90446d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon128() } },

        };
    }
}
    
    