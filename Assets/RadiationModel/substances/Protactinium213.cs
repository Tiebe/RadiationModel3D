using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium213";
        public override double halfLife { get; } = 0.0053d;
        public override double atomicWeight { get; } = 213.0211d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium209() }, { 1.0d, new AlphaParticle(9407002.09) } } },

        };
    }
}
    