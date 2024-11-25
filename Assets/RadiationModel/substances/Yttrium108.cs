using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium108";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 107.96052d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium108() }, { 1.0d, new BetaParticle(-1, 7085000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    