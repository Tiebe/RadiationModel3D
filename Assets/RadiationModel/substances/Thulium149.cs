using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium149";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 148.95283d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium149() }, { 1.0d, new BetaParticle(1, 8853000.0) } } },
            { 0.002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium148() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    