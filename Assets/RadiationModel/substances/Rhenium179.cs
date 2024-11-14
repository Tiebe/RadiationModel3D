using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium179";
        public override double halfLife { get; } = 1170.0d;
        public override double atomicWeight { get; } = 178.94999d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2711000.0), new Tungsten179() } },

        };
    }
}
    
    