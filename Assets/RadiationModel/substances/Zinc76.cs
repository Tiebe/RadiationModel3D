
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc76 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc76";
        public override double halfLife { get; } = 5.7d;
        public override double atomicWeight { get; } = 75.93311d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium76() } },

        };
    }
}
    
    