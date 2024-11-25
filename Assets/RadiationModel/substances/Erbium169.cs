using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium169";
        public override double halfLife { get; } = 811468.8d;
        public override double atomicWeight { get; } = 168.9346d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium169() }, { 1.0d, new BetaParticle(-1, 176750.0) }, { 0.0017000000000000001d, new GammaParticle(8410.17, 0.14742) }, { 1.3e-05d, new GammaParticle(109779.24, 0.01129) }, { 1.4e-06d, new GammaParticle(118189.4, 0.01049) }, { 6.2082315125e-06d, new GammaParticle(8215.0, 0.15092) }, { 7.205447594253673e-06d, new GammaParticle(49773.0, 0.02491) }, { 1.2721482334487418e-05d, new GammaParticle(50742.0, 0.02443) }, { 4.159351247030879e-06d, new GammaParticle(57612.0, 0.02152) }, { 5.240782571258908e-06d, new GammaParticle(58257.0, 0.02128) }, { 1.0814313242280285e-06d, new GammaParticle(59034.0, 0.021) } } },

        };
    }
}
    