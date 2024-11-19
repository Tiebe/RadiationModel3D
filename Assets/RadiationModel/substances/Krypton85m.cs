using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton85m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton85m";
        public override double halfLife { get; } = 16128.0d;
        public override double atomicWeight { get; } = 84.91285d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7879999999999999d, new List<RadioactiveSubstance> { new BetaParticle(-1, 991941.0), new Rubidium85() } },
            { 0.212d, new List<RadioactiveSubstance> { new GammaParticle((304899.99999, 0.00407)), new Krypton85() } },

        };
    }
}
    
    