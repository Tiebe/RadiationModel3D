
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine93 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine93";
        public override double halfLife { get; } = 0.152d;
        public override double atomicWeight { get; } = 92.94322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Krypton93() } },

        };
    }
}
    
    