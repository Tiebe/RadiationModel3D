using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium216";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 216.00875d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10261047.4), new Francium212() } },

        };
    }
}
    
    