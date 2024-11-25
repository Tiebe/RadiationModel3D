using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium257";
        public override double halfLife { get; } = 4.4d;
        public override double atomicWeight { get; } = 257.10292d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7929999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nobelium253() }, { 1.0d, new AlphaParticle(10104002.09) } } },
            { 0.19399999999999998d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lawrencium257() } } },
            { 0.013000000000000001d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    