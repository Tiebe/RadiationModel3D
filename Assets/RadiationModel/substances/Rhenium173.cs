using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium173";
        public override double halfLife { get; } = 120.0d;
        public override double atomicWeight { get; } = 172.95324d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5173000.0), new Tungsten173() } },

        };
    }
}
    
    