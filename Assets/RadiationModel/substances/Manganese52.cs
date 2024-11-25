using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese52 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese52";
        public override double halfLife { get; } = 483062.4d;
        public override double atomicWeight { get; } = 51.94556d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium52() }, { 1.0d, new BetaParticle(1, 365820.0) }, { 0.0007599999999999999d, new GammaParticle(200580.0, 0.00618) }, { 0.0098d, new GammaParticle(346020.0, 0.00358) }, { 0.00089d, new GammaParticle(398090.0, 0.00311) }, { 0.00183d, new GammaParticle(399570.0, 0.0031) }, { 0.0021d, new GammaParticle(502060.0, 0.00247) }, { 0.0039000000000000003d, new GammaParticle(600160.0, 0.00207) }, { 0.004d, new GammaParticle(647470.0, 0.00191) }, { 0.9d, new GammaParticle(744233.0, 0.00167) }, { 0.0332d, new GammaParticle(848180.0, 0.00146) }, { 0.00043999999999999996d, new GammaParticle(901890.0, 0.00137) }, { 0.945d, new GammaParticle(935544.0, 0.00133) }, { 0.0007000000000000001d, new GammaParticle(1045750.0, 0.00119) }, { 0.0421d, new GammaParticle(1246278.0, 0.00099) }, { 0.0038d, new GammaParticle(1247880.0, 0.00099) }, { 0.0507d, new GammaParticle(1333649.0, 0.00093) }, { 1.0d, new GammaParticle(1434092.0, 0.00086) }, { 3e-05d, new GammaParticle(1441000.0, 0.00086) }, { 0.00047d, new GammaParticle(1645820.0, 0.00075) }, { 5e-05d, new GammaParticle(1839140.0, 0.00067) }, { 0.00034d, new GammaParticle(1981120.0, 0.00063) }, { 2.7000000000000002e-05d, new GammaParticle(2257420.0, 0.00055) }, { 0.5880236d, new GammaParticle(511000.0, 0.00243) }, { 0.0045337604605902d, new GammaParticle(597.0, 2.07679) }, { 0.05368825739795227d, new GammaParticle(5406.0, 0.22935) }, { 0.10545719386751574d, new GammaParticle(5415.0, 0.22896) }, { 0.021420977740331994d, new GammaParticle(5966.0, 0.20782) }, { 0.021420977740331994d, new GammaParticle(5966.0, 0.20782) } } },

        };
    }
}
    