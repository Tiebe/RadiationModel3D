using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium230";
        public override double halfLife { get; } = 35.0d;
        public override double atomicWeight { get; } = 230.04602d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium230() }, { 1.0d, new BetaParticle(1, 3815000.0) } } },
            { 0.3d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium230() } } },

        };
    }
}
    