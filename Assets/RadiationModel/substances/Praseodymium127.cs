using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium127";
        public override double halfLife { get; } = 4.2d;
        public override double atomicWeight { get; } = 126.93071d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum127() }, { 1.0d, new BetaParticle(1, 6678000.0) } } },

        };
    }
}
    