using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium220 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium220";
        public override double halfLife { get; } = 27.4d;
        public override double atomicWeight { get; } = 220.01233d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7820047.4), new Astatine216() } },
            { 0.0034999999999999996d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1210000.0), new Radium220() } },

        };
    }
}
    
    