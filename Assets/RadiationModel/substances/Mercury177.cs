using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury177 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury177";
        public override double halfLife { get; } = 0.117d;
        public override double atomicWeight { get; } = 176.98628d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum173() }, { 1.0d, new AlphaParticle(7757002.09) } } },

        };
    }
}
    