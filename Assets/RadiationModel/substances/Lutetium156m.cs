using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium156m";
        public override double halfLife { get; } = 0.494d;
        public override double atomicWeight { get; } = 155.95311d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium152() }, { 1.0d, new AlphaParticle(6637002.09) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium156() }, { 1.0d, new BetaParticle(1, 6577000.0) } } },

        };
    }
}
    