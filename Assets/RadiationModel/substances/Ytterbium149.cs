using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium149";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 148.96422d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium149() }, { 1.0d, new BetaParticle(1, 10206000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium148() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    