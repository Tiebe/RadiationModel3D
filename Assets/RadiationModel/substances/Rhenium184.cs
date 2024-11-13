
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium184";
        public override double halfLife { get; } = 3058560.0d;
        public override double atomicWeight { get; } = 183.95253d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tungsten184() } },

        };
    }
}
    
    