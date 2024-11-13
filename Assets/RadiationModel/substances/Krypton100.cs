
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton100 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton100";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 99.96299d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rubidium100() } },

        };
    }
}
    
    