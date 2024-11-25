using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium148";
        public override double halfLife { get; } = 2243697436.79349d;
        public override double atomicWeight { get; } = 147.91812d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium144() }, { 1.0d, new AlphaParticle(4293202.09) } } },

        };
    }
}
    