using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold172 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold172";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 171.98999d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium168() }, { 1.0d, new AlphaParticle(7947002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    