using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium171";
        public override double halfLife { get; } = 53.0d;
        public override double atomicWeight { get; } = 170.94147d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3197800.0), new Erbium171() } },

        };
    }
}
    
    