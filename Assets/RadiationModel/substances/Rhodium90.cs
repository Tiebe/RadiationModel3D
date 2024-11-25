using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium90";
        public override double halfLife { get; } = 0.029d;
        public override double atomicWeight { get; } = 89.94457d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium90() }, { 1.0d, new BetaParticle(1, 9547350.0) }, { 0.904d, new GammaParticle(738100.0, 0.00168) }, { 0.37064d, new GammaParticle(885700.0, 0.0014) }, { 0.7684000000000001d, new GammaParticle(900200.0, 0.00138) }, { 0.23504000000000003d, new GammaParticle(1163900.0, 0.00107) }, { 0.1808d, new GammaParticle(1316600.0, 0.00094) }, { 1.58d, new GammaParticle(511000.0, 0.00243) }, { 1.996d, new GammaParticle(511000.0, 0.00243) }, { 8.742899999999999e-05d, new GammaParticle(2737.0, 0.45299) }, { 0.0002862402190296d, new GammaParticle(2737.0, 0.45299) }, { 0.0012877587742954099d, new GammaParticle(19150.0, 0.06474) }, { 0.0003922891427393945d, new GammaParticle(19150.0, 0.06474) }, { 0.0024435650366136812d, new GammaParticle(19279.0, 0.06431) }, { 0.000744381675027314d, new GammaParticle(19279.0, 0.06431) }, { 0.0006566744572555157d, new GammaParticle(21736.0, 0.05704) }, { 0.00020004232550197235d, new GammaParticle(21736.0, 0.05704) }, { 0.0007630557193309091d, new GammaParticle(21875.0, 0.05668) }, { 0.00023244918223329185d, new GammaParticle(21875.0, 0.05668) }, { 0.00010638126207539356d, new GammaParticle(22072.0, 0.05617) }, { 3.240685673131952e-05d, new GammaParticle(22072.0, 0.05617) } } },
            { 0.006999999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium89() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    