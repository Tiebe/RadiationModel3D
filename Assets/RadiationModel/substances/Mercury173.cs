using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury173 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury173";
        public override double halfLife { get; } = 0.0008d;
        public override double atomicWeight { get; } = 172.99714d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum169() }, { 1.0d, new AlphaParticle(8397002.09) } } },

        };
    }
}
    