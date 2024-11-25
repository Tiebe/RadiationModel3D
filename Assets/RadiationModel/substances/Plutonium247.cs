using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium247";
        public override double halfLife { get; } = 196128.0d;
        public override double atomicWeight { get; } = 247.0743d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium247() }, { 1.0d, new BetaParticle(-1, 1030000.0) } } },

        };
    }
}
    