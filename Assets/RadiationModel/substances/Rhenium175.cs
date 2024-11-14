using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium175";
        public override double halfLife { get; } = 353.4d;
        public override double atomicWeight { get; } = 174.95138d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4345000.0), new Tungsten175() } },

        };
    }
}
    
    