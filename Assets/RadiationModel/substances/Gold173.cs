using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold173 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold173";
        public override double halfLife { get; } = 0.0263d;
        public override double atomicWeight { get; } = 172.98622d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium169() }, { 1.0d, new AlphaParticle(7858002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    