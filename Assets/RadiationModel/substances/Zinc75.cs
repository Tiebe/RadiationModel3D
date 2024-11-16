using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc75 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc75";
        public override double halfLife { get; } = 10.2d;
        public override double atomicWeight { get; } = 74.93284d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5901700.0), new Gallium75() } },

        };
    }
}
    
    