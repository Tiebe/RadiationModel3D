using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver94n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver94n";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 93.95072d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9540000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium94() } } },
            { 0.27d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium93() }, { 1.0d, new ProtonParticle() } } },
            { 0.040999999999999995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium93() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    