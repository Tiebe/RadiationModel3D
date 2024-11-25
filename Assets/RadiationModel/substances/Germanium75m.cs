using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium75m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium75m";
        public override double halfLife { get; } = 47.7d;
        public override double atomicWeight { get; } = 74.92301d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium75() }, { 0.000119d, new GammaParticle(61920.0, 0.02002) }, { 3.2e-05d, new GammaParticle(77860.0, 0.01592) }, { 0.395d, new GammaParticle(139680.0, 0.00888) }, { 0.0101489284078d, new GammaParticle(1221.0, 1.01543) }, { 0.08172814284680652d, new GammaParticle(9856.0, 0.1258) }, { 0.1587262436333395d, new GammaParticle(9887.0, 0.1254) }, { 0.03550349013684347d, new GammaParticle(11026.0, 0.11245) }, { 0.03628456691985403d, new GammaParticle(11038.0, 0.11232) }, { 0.0007810767830105564d, new GammaParticle(11099.0, 0.11171) } } },
            { 0.0003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic75() }, { 1.0d, new BetaParticle(-1, 658460.0) }, { 5e-05d, new GammaParticle(121150.0, 0.01023) }, { 0.0002d, new GammaParticle(136010.0, 0.00912) }, { 4.3e-05d, new GammaParticle(279480.0, 0.00444) }, { 3.9e-05d, new GammaParticle(400200.0, 0.0031) }, { 1.5513925751799998e-07d, new GammaParticle(1320.0, 0.93927) }, { 1.2662424262093762e-06d, new GammaParticle(10509.0, 0.11798) }, { 2.4572917256149355e-06d, new GammaParticle(10544.0, 0.11759) }, { 5.618668801076192e-07d, new GammaParticle(11773.0, 0.10531) }, { 5.831054481756873e-07d, new GammaParticle(11791.0, 0.10515) }, { 2.1238568068068005e-08d, new GammaParticle(11861.0, 0.10453) } } },

        };
    }
}
    