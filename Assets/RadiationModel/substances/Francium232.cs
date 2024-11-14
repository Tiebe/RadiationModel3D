using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium232";
        public override double halfLife { get; } = 5.5d;
        public override double atomicWeight { get; } = 232.04946d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5576000.0), new Radium232() } },

        };
    }
}
    
    