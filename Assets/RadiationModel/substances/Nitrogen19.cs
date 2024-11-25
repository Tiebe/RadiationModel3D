using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen19 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen19";
        public override double halfLife { get; } = 0.336d;
        public override double atomicWeight { get; } = 19.01702d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen19() }, { 1.0d, new BetaParticle(-1, 6261550.0) }, { 0.474d, new GammaParticle(96400.0, 0.01286) }, { 0.172d, new GammaParticle(1375700.0, 0.0009) }, { 0.156d, new GammaParticle(2475200.0, 0.0005) }, { 0.081d, new GammaParticle(3139000.0, 0.00039) }, { 0.22d, new GammaParticle(3851000.0, 0.00032) }, { 0.034d, new GammaParticle(3947000.0, 0.00031) } } },
            { 0.418d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen19() }, { 1.0d, new BetaParticle(-1, 6261550.0) }, { 0.474d, new GammaParticle(96400.0, 0.01286) }, { 0.172d, new GammaParticle(1375700.0, 0.0009) }, { 0.156d, new GammaParticle(2475200.0, 0.0005) }, { 0.081d, new GammaParticle(3139000.0, 0.00039) }, { 0.22d, new GammaParticle(3851000.0, 0.00032) }, { 0.034d, new GammaParticle(3947000.0, 0.00031) } } },

        };
    }
}
    