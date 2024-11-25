using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium157";
        public override double halfLife { get; } = 1.15d;
        public override double atomicWeight { get; } = 156.93935d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium157() }, { 1.0d, new BetaParticle(-1, 2901450.0) } } },

        };
    }
}
    