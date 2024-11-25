using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium130";
        public override double halfLife { get; } = 13.0d;
        public override double atomicWeight { get; } = 129.92851d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium130() }, { 1.0d, new BetaParticle(1, 6413500.0) } } },

        };
    }
}
    