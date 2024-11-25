using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium129";
        public override double halfLife { get; } = 2.4d;
        public override double atomicWeight { get; } = 128.94291d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium129() }, { 1.0d, new BetaParticle(1, 8297000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    