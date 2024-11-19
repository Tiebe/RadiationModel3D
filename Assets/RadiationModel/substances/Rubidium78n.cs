using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium78n : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium78n";
        public override double halfLife { get; } = 344.4d;
        public override double atomicWeight { get; } = 77.92826d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.91d, new List<RadioactiveSubstance> { new BetaParticle(1, 7354300.0), new Krypton78() } },
            { 0.09d, new List<RadioactiveSubstance> { new GammaParticle((111000.0, 0.01117)), new Rubidium78() } },

        };
    }
}
    
    