using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten190 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten190";
        public override double halfLife { get; } = 1800.0d;
        public override double atomicWeight { get; } = 189.9631d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1213000.0), new Rhenium190() } },

        };
    }
}
    
    