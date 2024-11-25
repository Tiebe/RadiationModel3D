using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium264";
        public override double halfLife { get; } = 0.44d;
        public override double atomicWeight { get; } = 264.12449d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dubnium260() }, { 1.0d, new AlphaParticle(10887002.09) } } },

        };
    }
}
    