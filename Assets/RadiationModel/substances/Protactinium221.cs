using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium221";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 221.02187d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium217() }, { 1.0d, new AlphaParticle(10265002.09) } } },

        };
    }
}
    