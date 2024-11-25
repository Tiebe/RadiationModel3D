using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium230";
        public override double halfLife { get; } = 276.0d;
        public override double atomicWeight { get; } = 230.03783d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.97d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium230() }, { 1.0d, new BetaParticle(1, 1533000.0) } } },
            { 0.03d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium226() }, { 1.0d, new AlphaParticle(7803002.09) } } },

        };
    }
}
    