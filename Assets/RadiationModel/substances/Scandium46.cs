
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium46 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium46";
        public override double halfLife { get; } = 7236604.8d;
        public override double atomicWeight { get; } = 45.95517d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Titanium46() } },

        };
    }
}
    
    