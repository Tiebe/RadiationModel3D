using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium75 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium75";
        public override double halfLife { get; } = 19.0d;
        public override double atomicWeight { get; } = 74.93857d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine75() }, { 1.0d, new BetaParticle(1, 5944150.0) }, { 0.0011d, new GammaParticle(171000.0, 0.00725) }, { 0.748d, new GammaParticle(178950.0, 0.00693) }, { 0.35200000000000004d, new GammaParticle(179260.0, 0.00692) }, { 0.0836d, new GammaParticle(187000.0, 0.00663) }, { 0.0187d, new GammaParticle(253100.0, 0.0049) }, { 0.0308d, new GammaParticle(313600.0, 0.00395) }, { 0.0616d, new GammaParticle(358000.0, 0.00346) }, { 0.0132d, new GammaParticle(432200.0, 0.00287) }, { 0.0605d, new GammaParticle(450200.0, 0.00275) }, { 0.011000000000000001d, new GammaParticle(475200.0, 0.00261) }, { 0.0649d, new GammaParticle(493000.0, 0.00251) }, { 0.011000000000000001d, new GammaParticle(522500.0, 0.00237) }, { 0.0088d, new GammaParticle(628800.0, 0.00197) }, { 0.0275d, new GammaParticle(654200.0, 0.0019) }, { 0.077d, new GammaParticle(671800.0, 0.00185) }, { 0.019799999999999998d, new GammaParticle(701800.0, 0.00177) }, { 0.0077d, new GammaParticle(791300.0, 0.00157) }, { 0.011000000000000001d, new GammaParticle(854900.0, 0.00145) }, { 0.0231d, new GammaParticle(863200.0, 0.00144) }, { 0.011000000000000001d, new GammaParticle(1026400.0, 0.00121) }, { 0.0088d, new GammaParticle(1042900.0, 0.00119) }, { 0.0341d, new GammaParticle(1197100.0, 0.00104) }, { 0.0451d, new GammaParticle(1690100.0, 0.00073) }, { 2.012d, new GammaParticle(511000.0, 0.00243) }, { 0.00095d, new GammaParticle(1648.0, 0.75233) }, { 0.0067d, new GammaParticle(12596.0, 0.09843) }, { 0.0129d, new GammaParticle(12649.0, 0.09802) }, { 0.0031d, new GammaParticle(14169.0, 0.0875) }, { 0.0034000000000000002d, new GammaParticle(14209.0, 0.08726) }, { 0.00031d, new GammaParticle(14313.0, 0.08662) } } },

        };
    }
}
    