
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium53 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium53";
        public override double halfLife { get; } = 32.7d;
        public override double atomicWeight { get; } = 52.94967d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Vanadium53() } },

        };
    }
}
    
    