using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium105";
        public override double halfLife { get; } = 2.91d;
        public override double atomicWeight { get; } = 104.92494d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7415000.0), new Molybdenum105() } },

        };
    }
}
    
    