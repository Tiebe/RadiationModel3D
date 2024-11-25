using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium238";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 238.05821d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium238() }, { 1.0d, new BetaParticle(1, 2900000.0) } } },
            { 0.00048d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    