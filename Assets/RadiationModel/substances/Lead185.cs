using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead185 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead185";
        public override double halfLife { get; } = 6.3d;
        public override double atomicWeight { get; } = 184.98761d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.34d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury181() }, { 1.0d, new AlphaParticle(7717002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    