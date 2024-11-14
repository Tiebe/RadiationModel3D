using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium232";
        public override double halfLife { get; } = 240.0d;
        public override double atomicWeight { get; } = 232.04348d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1343000.0), new Actinium232() } },

        };
    }
}
    
    