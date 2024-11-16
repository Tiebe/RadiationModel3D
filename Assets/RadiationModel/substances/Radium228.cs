using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium228";
        public override double halfLife { get; } = 181452474.0d;
        public override double atomicWeight { get; } = 228.03107d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 45500.0), new Actinium228() } },

        };
    }
}
    
    