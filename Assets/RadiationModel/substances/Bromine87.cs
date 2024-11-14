using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine87 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine87";
        public override double halfLife { get; } = 55.68d;
        public override double atomicWeight { get; } = 86.92067d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6817530.0), new Krypton87() } },

        };
    }
}
    
    