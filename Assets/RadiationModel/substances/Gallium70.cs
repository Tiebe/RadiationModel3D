using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium70 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium70";
        public override double halfLife { get; } = 1268.4d;
        public override double atomicWeight { get; } = 69.92602d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9959d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium70() }, { 1.0d, new BetaParticle(-1, 825900.0) }, { 0.0029d, new GammaParticle(176115.0, 0.00704) }, { 0.006500000000000001d, new GammaParticle(1039513.0, 0.00119) }, { 4.502970997e-06d, new GammaParticle(1221.0, 1.01543) }, { 3.7660809980836175e-05d, new GammaParticle(9856.0, 0.1258) }, { 7.31419886984583e-05d, new GammaParticle(9887.0, 0.1254) }, { 1.6360217534936925e-05d, new GammaParticle(11026.0, 0.11245) }, { 1.6720142320705537e-05d, new GammaParticle(11038.0, 0.11232) }, { 3.5992478576861236e-07d, new GammaParticle(11099.0, 0.11171) } } },
            { 0.0040999999999999995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc70() }, { 5.6237937984e-05d, new GammaParticle(1035.0, 1.19791) }, { 0.0005232139080602494d, new GammaParticle(8616.0, 0.1439) }, { 0.0010175299651113369d, new GammaParticle(8639.0, 0.14352) }, { 0.0002183234068284138d, new GammaParticle(9610.0, 0.12902) }, { 0.0002183234068284138d, new GammaParticle(9610.0, 0.12902) } } },

        };
    }
}
    