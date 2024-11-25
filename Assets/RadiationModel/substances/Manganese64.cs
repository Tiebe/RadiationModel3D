using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese64 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese64";
        public override double halfLife { get; } = 0.09d;
        public override double atomicWeight { get; } = 63.95385d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron64() }, { 1.0d, new BetaParticle(-1, 5990500.0) } } },
            { 0.027000000000000003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron64() }, { 1.0d, new BetaParticle(-1, 5990500.0) } } },

        };
    }
}
    