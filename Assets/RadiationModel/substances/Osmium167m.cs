using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium167m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 166.97201d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium167() }, { 0.1056d, new GammaParticle(86700.0, 0.0143) }, { 0.6139d, new GammaParticle(347600.0, 0.00357) }, { 0.32133504172000005d, new GammaParticle(10393.0, 0.1193) }, { 0.28925000629306163d, new GammaParticle(61486.0, 0.02016) }, { 0.49844908890756784d, new GammaParticle(63000.0, 0.01968) }, { 0.16677066781200828d, new GammaParticle(71496.0, 0.01734) }, { 0.2134664547993706d, new GammaParticle(72338.0, 0.01714) }, { 0.04669578698736232d, new GammaParticle(73364.0, 0.0169) } } },

        };
    }
}
    