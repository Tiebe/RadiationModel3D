using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium74 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium74";
        public override double halfLife { get; } = 0.027d;
        public override double atomicWeight { get; } = 73.95617d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton74() }, { 1.0d, new BetaParticle(1, 10750900.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    