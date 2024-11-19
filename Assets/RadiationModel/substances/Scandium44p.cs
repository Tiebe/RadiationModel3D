using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium44p : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium44p";
        public override double halfLife { get; } = 210996.0d;
        public override double atomicWeight { get; } = 43.95969d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.988d, new List<RadioactiveSubstance> { new GammaParticle(0.00457, 271200.0), new Scandium44() } },
            { 0.012d, new List<RadioactiveSubstance> { new BetaParticle(1, 3923900.0), new Calcium44() } },

        };
    }
}
    
    