using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine146 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine146";
        public override double halfLife { get; } = 0.094d;
        public override double atomicWeight { get; } = 145.96185d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon146() }, { 1.0d, new BetaParticle(-1, 6207500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    