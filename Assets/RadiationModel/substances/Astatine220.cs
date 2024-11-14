using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine220 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine220";
        public override double halfLife { get; } = 222.6d;
        public override double atomicWeight { get; } = 220.01543d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.92d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3764000.0), new Radon220() } },
            { 0.08d, new List<RadioactiveSubstance> { new AlphaParticle(7097047.4), new Bismuth216() } },

        };
    }
}
    
    