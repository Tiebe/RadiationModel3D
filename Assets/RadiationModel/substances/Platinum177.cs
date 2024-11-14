using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum177 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum177";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 176.96847d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.943d, new List<RadioactiveSubstance> { new BetaParticle(1, 6677000.0), new Iridium177() } },
            { 0.057d, new List<RadioactiveSubstance> { new AlphaParticle(6663047.4), new Osmium173() } },

        };
    }
}
    
    