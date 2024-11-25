using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium102m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium102m";
        public override double halfLife { get; } = 0.36d;
        public override double atomicWeight { get; } = 101.93444d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium102() }, { 1.0d, new BetaParticle(-1, 5255500.0) } } },
            { 0.049d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium102() }, { 1.0d, new BetaParticle(-1, 5255500.0) } } },

        };
    }
}
    