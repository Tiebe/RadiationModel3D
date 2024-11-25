using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium150";
        public override double halfLife { get; } = 0.045d;
        public override double atomicWeight { get; } = 149.97341d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7090000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium149() }, { 1.0d, new ProtonParticle() } } },
            { 0.29100000000000004d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium150() }, { 1.0d, new BetaParticle(1, 10860000.0) } } },

        };
    }
}
    