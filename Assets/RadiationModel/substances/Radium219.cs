using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium219";
        public override double halfLife { get; } = 0.009d;
        public override double atomicWeight { get; } = 219.01008d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon215() }, { 1.0d, new AlphaParticle(9160002.09) }, { 0.008d, new GammaParticle(214100.0, 0.00579) }, { 0.0088d, new GammaParticle(290800.0, 0.00426) }, { 0.44d, new GammaParticle(315820.0, 0.00393) }, { 0.011200000000000002d, new GammaParticle(592000.0, 0.00209) }, { 0.0068000000000000005d, new GammaParticle(805200.0, 0.00154) }, { 0.07583543858048d, new GammaParticle(14088.0, 0.08801) }, { 0.051035328307097935d, new GammaParticle(81070.0, 0.01529) }, { 0.08418892825321336d, new GammaParticle(83789.0, 0.0148) }, { 0.029196146302794483d, new GammaParticle(94878.0, 0.01307) }, { 0.03853891311968872d, new GammaParticle(96054.0, 0.01291) }, { 0.009342766816894235d, new GammaParticle(97530.0, 0.01271) } } },

        };
    }
}
    