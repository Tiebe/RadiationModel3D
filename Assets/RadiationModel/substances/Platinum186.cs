using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum186 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum186";
        public override double halfLife { get; } = 7488.0d;
        public override double atomicWeight { get; } = 185.95935d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1308000.0), new Iridium186() } },
            { 1.4e-06d, new List<RadioactiveSubstance> { new AlphaParticle(5342002.09), new Osmium182() } },

        };
    }
}
    
    