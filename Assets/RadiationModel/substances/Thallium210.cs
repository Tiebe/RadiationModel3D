using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium210 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium210";
        public override double halfLife { get; } = 78.0d;
        public override double atomicWeight { get; } = 209.99007d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5481400.0), new Lead210() } },

        };
    }
}
    
    