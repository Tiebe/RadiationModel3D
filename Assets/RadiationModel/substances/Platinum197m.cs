using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum197m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum197m";
        public override double halfLife { get; } = 5724.6d;
        public override double atomicWeight { get; } = 196.96777d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9670000000000001d, new List<RadioactiveSubstance> { new GammaParticle((399600.00002, 0.0031)), new Platinum197() } },
            { 0.033d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1119600.0), new Gold197() } },

        };
    }
}
    
    