using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium156";
        public override double halfLife { get; } = 0.444d;
        public override double atomicWeight { get; } = 155.94477d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium156() }, { 1.0d, new BetaParticle(-1, 4376399.99999) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    