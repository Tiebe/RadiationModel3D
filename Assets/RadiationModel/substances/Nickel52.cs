using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel52 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel52";
        public override double halfLife { get; } = 0.0408d;
        public override double atomicWeight { get; } = 51.97578d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron52() }, { 1.0d, new BetaParticle(1, 12886050.0) }, { 0.38d, new GammaParticle(2418300.0, 0.00051) } } },
            { 0.314d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron51() }, { 1.0d, new BetaParticle(1, 474561651.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    