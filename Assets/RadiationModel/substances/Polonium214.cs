using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium214";
        public override double halfLife { get; } = 0.00016d;
        public override double atomicWeight { get; } = 213.9952d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead210() }, { 1.0d, new AlphaParticle(8855402.09) }, { 5.22e-07d, new GammaParticle(298000.0, 0.00416) }, { 0.00010352999999999999d, new GammaParticle(799700.0, 0.00155) }, { 3.4476351507930004e-07d, new GammaParticle(12522.0, 0.09901) }, { 2.449251241808231e-07d, new GammaParticle(72805.0, 0.01703) }, { 4.116388641694506e-07d, new GammaParticle(74970.0, 0.01654) }, { 1.4069228321791576e-07d, new GammaParticle(84986.0, 0.01459) }, { 1.8318135274972634e-07d, new GammaParticle(86022.0, 0.01441) }, { 4.248906953181056e-08d, new GammaParticle(87301.0, 0.0142) } } },

        };
    }
}
    