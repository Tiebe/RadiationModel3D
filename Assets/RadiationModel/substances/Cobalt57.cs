using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt57 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt57";
        public override double halfLife { get; } = 23478336.0d;
        public override double atomicWeight { get; } = 56.93629d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron57() }, { 0.0916d, new GammaParticle(14412.9, 0.08602) }, { 0.856d, new GammaParticle(122060.65, 0.01016) }, { 0.10679999999999999d, new GammaParticle(136473.56, 0.00908) }, { 4e-06d, new GammaParticle(230400.0, 0.00538) }, { 3.7000000000000005e-05d, new GammaParticle(339690.0, 0.00365) }, { 3e-05d, new GammaParticle(352330.0, 0.00352) }, { 1.1999999999999999e-05d, new GammaParticle(366800.0, 0.00338) }, { 0.00015800000000000002d, new GammaParticle(570090.0, 0.00217) }, { 0.00149d, new GammaParticle(692410.0, 0.00179) }, { 5e-05d, new GammaParticle(706540.0, 0.00175) }, { 0.014857805102969279d, new GammaParticle(728.0, 1.70308) }, { 0.16807075542101763d, new GammaParticle(6391.0, 0.194) }, { 0.32909879659490426d, new GammaParticle(6404.0, 0.1936) }, { 0.0680127947157781d, new GammaParticle(7082.0, 0.17507) }, { 0.0680127947157781d, new GammaParticle(7082.0, 0.17507) } } },

        };
    }
}
    