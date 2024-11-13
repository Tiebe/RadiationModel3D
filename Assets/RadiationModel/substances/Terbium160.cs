
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium160";
        public override double halfLife { get; } = 6246720.0d;
        public override double atomicWeight { get; } = 159.92717d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium160() } },

        };
    }
}
    
    