using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium157";
        public override double halfLife { get; } = 0.295d;
        public override double atomicWeight { get; } = 156.948d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium157() }, { 1.0d, new BetaParticle(-1, 4029550.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    