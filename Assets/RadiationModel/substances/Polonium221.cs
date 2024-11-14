using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium221";
        public override double halfLife { get; } = 132.0d;
        public override double atomicWeight { get; } = 221.02123d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2991000.0), new Astatine221() } },

        };
    }
}
    
    