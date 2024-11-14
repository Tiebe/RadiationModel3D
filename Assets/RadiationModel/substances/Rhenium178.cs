using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium178";
        public override double halfLife { get; } = 792.0d;
        public override double atomicWeight { get; } = 177.95099d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4754000.0), new Tungsten178() } },

        };
    }
}
    
    