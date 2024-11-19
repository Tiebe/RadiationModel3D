using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury193m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury193m";
        public override double halfLife { get; } = 42480.0d;
        public override double atomicWeight { get; } = 192.9668d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9279999999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 2484000.0), new Gold193() } },
            { 0.07200000000000001d, new List<RadioactiveSubstance> { new GammaParticle((141000.0, 0.00879)), new Mercury193() } },

        };
    }
}
    
    