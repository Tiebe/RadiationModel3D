using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium202 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium202";
        public override double halfLife { get; } = 0.372d;
        public override double atomicWeight { get; } = 202.00333d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine198() }, { 1.0d, new AlphaParticle(8408002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    