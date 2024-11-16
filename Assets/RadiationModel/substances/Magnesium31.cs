using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium31 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium31";
        public override double halfLife { get; } = 0.27d;
        public override double atomicWeight { get; } = 30.99665d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11828700.0), new Aluminum31() } },

        };
    }
}
    
    