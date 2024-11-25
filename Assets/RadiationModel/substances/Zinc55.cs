using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc55 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc55";
        public override double halfLife { get; } = 0.0198d;
        public override double atomicWeight { get; } = 54.98468d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel55() }, { 1.0d, new BetaParticle(1, 15533000.0) } } },
            { 0.91d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel54() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    