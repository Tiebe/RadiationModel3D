using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium223";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 223.02797d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium219() }, { 1.0d, new AlphaParticle(10187002.09) } } },
            { 0.002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium223() }, { 1.0d, new BetaParticle(1, 3332500.0) } } },

        };
    }
}
    