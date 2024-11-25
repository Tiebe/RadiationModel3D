using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium160";
        public override double halfLife { get; } = 0.00061d;
        public override double atomicWeight { get; } = 159.98188d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten159() }, { 1.0d, new ProtonParticle() } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum156() }, { 1.0d, new AlphaParticle(7717002.09) } } },

        };
    }
}
    