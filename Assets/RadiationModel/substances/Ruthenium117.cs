using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium117";
        public override double halfLife { get; } = 0.151d;
        public override double atomicWeight { get; } = 116.93613d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium117() }, { 1.0d, new BetaParticle(-1, 4703500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    