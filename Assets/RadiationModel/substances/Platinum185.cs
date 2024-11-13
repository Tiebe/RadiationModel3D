
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum185 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum185";
        public override double halfLife { get; } = 4254.0d;
        public override double atomicWeight { get; } = 184.96061d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iridium185() } },

            { 5e-05d, new List<RadioactiveSubstance> { new AlphaParticle(), new Osmium181() } },

        };
    }
}
    
    