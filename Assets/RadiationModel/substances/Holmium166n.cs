using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium166n : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium166n";
        public override double halfLife { get; } = 0.00018d;
        public override double atomicWeight { get; } = 165.9325d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium166() }, { 0.07d, new GammaParticle(19840.0, 0.06249) }, { 0.03d, new GammaParticle(54239.0, 0.02286) }, { 0.13d, new GammaParticle(116835.0, 0.01061) }, { 0.5d, new GammaParticle(136662.0, 0.00907) }, { 0.25132015038d, new GammaParticle(7656.0, 0.16194) }, { 0.06449011094553517d, new GammaParticle(46700.0, 0.02655) }, { 0.11485326971600207d, new GammaParticle(47547.0, 0.02608) }, { 0.03710699947497045d, new GammaParticle(53982.0, 0.02297) }, { 0.04675481933846276d, new GammaParticle(54577.0, 0.02272) }, { 0.009647819863492318d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    