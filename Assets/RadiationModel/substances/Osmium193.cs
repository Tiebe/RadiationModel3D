
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium193 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium193";
        public override double halfLife { get; } = 107388.0d;
        public override double atomicWeight { get; } = 192.96415d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iridium193() } },

        };
    }
}
    
    