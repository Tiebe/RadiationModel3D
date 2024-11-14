using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium188 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium188";
        public override double halfLife { get; } = 0.00027d;
        public override double atomicWeight { get; } = 187.99942d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9103047.4), new Lead184() } },

        };
    }
}
    
    