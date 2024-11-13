
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine128 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine128";
        public override double halfLife { get; } = 1499.4d;
        public override double atomicWeight { get; } = 127.90581d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9309999999999999d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon128() } },

            { 0.069d, new List<RadioactiveSubstance> { new BetaParticle(), new Tellurium128() } },

        };
    }
}
    
    