using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hydrogen3 : RadioactiveSubstance
    {
        public override string name { get; } = "Hydrogen3";
        public override double halfLife { get; } = 388781328.00697d;
        public override double atomicWeight { get; } = 3.01605d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Helium3() }, { 1.0d, new BetaParticle(-1, 9296.01) } } },

        };
    }
}
    