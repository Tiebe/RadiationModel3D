using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten169 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten169";
        public override double halfLife { get; } = 74.0d;
        public override double atomicWeight { get; } = 168.95178d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium169() }, { 1.0d, new BetaParticle(1, 4899500.0) } } },

        };
    }
}
    