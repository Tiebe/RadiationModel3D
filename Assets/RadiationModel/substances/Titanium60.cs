
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium60 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium60";
        public override double halfLife { get; } = 0.0222d;
        public override double atomicWeight { get; } = 59.97627d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Vanadium60() } },

        };
    }
}
    
    