using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium148";
        public override double halfLife { get; } = 2250010677.6d;
        public override double atomicWeight { get; } = 147.91812d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(4293202.09), new Samarium144() } },

        };
    }
}
    
    