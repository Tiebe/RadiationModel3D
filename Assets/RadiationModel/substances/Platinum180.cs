using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum180 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum180";
        public override double halfLife { get; } = 56.0d;
        public override double atomicWeight { get; } = 179.96304d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9948d, new List<RadioactiveSubstance> { new BetaParticle(1, 3548000.0), new Iridium180() } },
            { 0.0052d, new List<RadioactiveSubstance> { new AlphaParticle(6296047.4), new Osmium176() } },

        };
    }
}
    
    