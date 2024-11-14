using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium225";
        public override double halfLife { get; } = 237.0d;
        public override double atomicWeight { get; } = 225.02557d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1828000.0), new Radium225() } },

        };
    }
}
    
    