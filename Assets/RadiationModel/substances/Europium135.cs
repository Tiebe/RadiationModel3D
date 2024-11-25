using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium135";
        public override double halfLife { get; } = 1.5d;
        public override double atomicWeight { get; } = 134.94187d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium135() }, { 1.0d, new BetaParticle(1, 7955000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    