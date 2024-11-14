using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur39 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur39";
        public override double halfLife { get; } = 11.5d;
        public override double atomicWeight { get; } = 38.97514d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6640200.0), new Chlorine39() } },

        };
    }
}
    
    