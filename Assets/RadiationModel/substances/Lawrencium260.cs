using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium260";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 260.10551d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mendelevium256() }, { 1.0d, new AlphaParticle(9417002.09) } } },
            { 0.4d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nobelium260() } } },

        };
    }
}
    