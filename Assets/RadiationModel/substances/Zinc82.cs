using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc82 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc82";
        public override double halfLife { get; } = 0.1779d;
        public override double atomicWeight { get; } = 81.95457d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10616700.0), new Gallium82() } },

        };
    }
}
    
    