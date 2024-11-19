using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium150";
        public override double halfLife { get; } = 56486944080000.0d;
        public override double atomicWeight { get; } = 149.91866d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(3829002.09), new Samarium146() } },

        };
    }
}
    
    