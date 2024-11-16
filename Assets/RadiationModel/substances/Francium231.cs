using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium231";
        public override double halfLife { get; } = 17.6d;
        public override double atomicWeight { get; } = 231.04518d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3865000.0), new Radium231() } },

        };
    }
}
    
    