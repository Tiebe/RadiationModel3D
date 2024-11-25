using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium150";
        public override double halfLife { get; } = 0.259d;
        public override double atomicWeight { get; } = 149.94644d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum150() }, { 1.0d, new BetaParticle(-1, 3210550.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    