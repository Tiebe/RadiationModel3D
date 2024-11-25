using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium170";
        public override double halfLife { get; } = 7.37d;
        public override double atomicWeight { get; } = 169.96358d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.905d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten170() }, { 1.0d, new BetaParticle(1, 6682500.0) } } },
            { 0.095d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten166() }, { 1.0d, new AlphaParticle(6558002.09) } } },

        };
    }
}
    