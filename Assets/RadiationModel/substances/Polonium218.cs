using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium218";
        public override double halfLife { get; } = 185.82d;
        public override double atomicWeight { get; } = 218.00897d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9998d, new List<RadioactiveSubstance> { new AlphaParticle(7134747.4), new Lead214() } },
            { 0.0002d, new List<RadioactiveSubstance> { new BetaParticle(-1, 256700.0), new Astatine218() } },

        };
    }
}
    
    