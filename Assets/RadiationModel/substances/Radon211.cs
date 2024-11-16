using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon211 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon211";
        public override double halfLife { get; } = 52560.0d;
        public override double atomicWeight { get; } = 210.9906d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.726d, new List<RadioactiveSubstance> { new BetaParticle(1, 2892200.0), new Astatine211() } },
            { 0.27399999999999997d, new List<RadioactiveSubstance> { new AlphaParticle(6986047.4), new Polonium207() } },

        };
    }
}
    
    