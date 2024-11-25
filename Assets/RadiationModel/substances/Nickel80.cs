using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel80 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel80";
        public override double halfLife { get; } = 0.024d;
        public override double atomicWeight { get; } = 79.97505d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper80() }, { 1.0d, new BetaParticle(-1, 6720000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    