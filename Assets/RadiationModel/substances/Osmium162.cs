using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium162";
        public override double halfLife { get; } = 0.0021d;
        public override double atomicWeight { get; } = 161.98443d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7785047.4), new Tungsten158() } },

        };
    }
}
    
    