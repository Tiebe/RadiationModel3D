using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium146";
        public override double halfLife { get; } = 3.32d;
        public override double atomicWeight { get; } = 145.94499d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium146() }, { 1.0d, new BetaParticle(1, 8261000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    