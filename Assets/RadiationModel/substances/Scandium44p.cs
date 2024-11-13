
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

            { 0.988d, new List<RadioactiveSubstance> { new GammaParticle(), new Scandium44() } },

            { 0.012d, new List<RadioactiveSubstance> { new BetaParticle(), new Calcium44() } },

        };
    }
}
    
    