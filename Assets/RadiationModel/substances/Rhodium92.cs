using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium92";
        public override double halfLife { get; } = 4.66d;
        public override double atomicWeight { get; } = 91.93237d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium92() }, { 1.0d, new BetaParticle(1, 7963500.0) }, { 0.068d, new GammaParticle(163100.0, 0.0076) }, { 0.43d, new GammaParticle(339900.0, 0.00365) }, { 0.76d, new GammaParticle(817800.0, 0.00152) }, { 1.03d, new GammaParticle(865700.0, 0.00143) }, { 0.1d, new GammaParticle(919100.0, 0.00135) }, { 1.0d, new GammaParticle(991100.0, 0.00125) }, { 2.002d, new GammaParticle(511000.0, 0.00243) }, { 0.0011762818158d, new GammaParticle(2737.0, 0.45299) }, { 0.00517942456979951d, new GammaParticle(19150.0, 0.06474) }, { 0.009828130113471558d, new GammaParticle(19279.0, 0.06431) }, { 0.0026411746409026964d, new GammaParticle(21736.0, 0.05704) }, { 0.003069044932728933d, new GammaParticle(21875.0, 0.05668) }, { 0.00042787029182623685d, new GammaParticle(22072.0, 0.05617) } } },
            { 0.019d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium91() }, { 1.0d, new BetaParticle(1, 472240901.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    