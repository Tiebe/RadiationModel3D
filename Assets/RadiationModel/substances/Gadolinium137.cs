using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium137";
        public override double halfLife { get; } = 2.2d;
        public override double atomicWeight { get; } = 136.94502d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium137() }, { 1.0d, new BetaParticle(1, 8391000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    