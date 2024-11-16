using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tennessine294 : RadioactiveSubstance
    {
        public override string name { get; } = "Tennessine294";
        public override double halfLife { get; } = 0.07d;
        public override double atomicWeight { get; } = 294.21084d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(12205047.4), new Moscovium290() } },

        };
    }
}
    
    