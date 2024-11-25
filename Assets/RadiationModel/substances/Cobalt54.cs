using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt54 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt54";
        public override double halfLife { get; } = 0.19328d;
        public override double atomicWeight { get; } = 53.94846d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese54() }, { 1.0d, new BetaParticle(1, 3774050.0) }, { 4.4999999999999996e-05d, new GammaParticle(1153000.0, 0.00108) }, { 1.997954d, new GammaParticle(511000.0, 0.00243) }, { 8.85382943966196e-06d, new GammaParticle(728.0, 1.70308) }, { 0.00010031662484882313d, new GammaParticle(6391.0, 0.194) }, { 0.0001964296550789566d, new GammaParticle(6404.0, 0.1936) }, { 4.0594891094120263e-05d, new GammaParticle(7082.0, 0.17507) }, { 4.0594891094120263e-05d, new GammaParticle(7082.0, 0.17507) } } },

        };
    }
}
    