using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium179";
        public override double halfLife { get; } = 390.0d;
        public override double atomicWeight { get; } = 178.95382d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten179() }, { 1.0d, new BetaParticle(1, 3137500.0) } } },

        };
    }
}
    