using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium270 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium270";
        public override double halfLife { get; } = 0.48d;
        public override double atomicWeight { get; } = 270.14032d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bohrium266() }, { 1.0d, new AlphaParticle(11207002.09) } } },

        };
    }
}
    