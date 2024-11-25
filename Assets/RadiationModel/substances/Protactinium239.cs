using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium239";
        public override double halfLife { get; } = 6480.0d;
        public override double atomicWeight { get; } = 239.05726d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium239() }, { 1.0d, new BetaParticle(-1, 1383650.00001) } } },

        };
    }
}
    