using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium165";
        public override double halfLife { get; } = 0.071d;
        public override double atomicWeight { get; } = 164.97665d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new AlphaParticle(7355047.4), new Tungsten161() } },
            { 0.1d, new List<RadioactiveSubstance> { new BetaParticle(1, 8909000.0), new Rhenium165() } },

        };
    }
}
    
    