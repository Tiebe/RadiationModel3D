using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus40 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus40";
        public override double halfLife { get; } = 0.15d;
        public override double atomicWeight { get; } = 39.99126d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur40() }, { 1.0d, new BetaParticle(-1, 7349000.0) }, { 0.035910000000000004d, new GammaParticle(648820.0, 0.00191) }, { 0.035910000000000004d, new GammaParticle(834900.0, 0.00149) }, { 0.63d, new GammaParticle(903680.0, 0.00137) }, { 0.01575d, new GammaParticle(981200.0, 0.00126) }, { 0.03276d, new GammaParticle(1013170.0, 0.00122) }, { 0.07875d, new GammaParticle(1351100.0, 0.00092) }, { 0.0069299999999999995d, new GammaParticle(1692600.0, 0.00073) }, { 0.00882d, new GammaParticle(1773200.0, 0.0007) }, { 0.00315d, new GammaParticle(2254500.0, 0.00055) }, { 0.04032d, new GammaParticle(2469790.0, 0.0005) }, { 0.010709999999999999d, new GammaParticle(2550400.0, 0.00049) }, { 0.02016d, new GammaParticle(2585600.0, 0.00048) }, { 0.01638d, new GammaParticle(2614800.0, 0.00047) }, { 0.03465d, new GammaParticle(2808200.0, 0.00044) }, { 0.027719999999999998d, new GammaParticle(3043200.0, 0.00041) }, { 0.26145d, new GammaParticle(3234700.0, 0.00038) }, { 0.15686999999999998d, new GammaParticle(3489600.0, 0.00036) }, { 0.10395d, new GammaParticle(4105700.0, 0.0003) } } },
            { 0.158d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur40() }, { 1.0d, new BetaParticle(-1, 7349000.0) }, { 0.035910000000000004d, new GammaParticle(648820.0, 0.00191) }, { 0.035910000000000004d, new GammaParticle(834900.0, 0.00149) }, { 0.63d, new GammaParticle(903680.0, 0.00137) }, { 0.01575d, new GammaParticle(981200.0, 0.00126) }, { 0.03276d, new GammaParticle(1013170.0, 0.00122) }, { 0.07875d, new GammaParticle(1351100.0, 0.00092) }, { 0.0069299999999999995d, new GammaParticle(1692600.0, 0.00073) }, { 0.00882d, new GammaParticle(1773200.0, 0.0007) }, { 0.00315d, new GammaParticle(2254500.0, 0.00055) }, { 0.04032d, new GammaParticle(2469790.0, 0.0005) }, { 0.010709999999999999d, new GammaParticle(2550400.0, 0.00049) }, { 0.02016d, new GammaParticle(2585600.0, 0.00048) }, { 0.01638d, new GammaParticle(2614800.0, 0.00047) }, { 0.03465d, new GammaParticle(2808200.0, 0.00044) }, { 0.027719999999999998d, new GammaParticle(3043200.0, 0.00041) }, { 0.26145d, new GammaParticle(3234700.0, 0.00038) }, { 0.15686999999999998d, new GammaParticle(3489600.0, 0.00036) }, { 0.10395d, new GammaParticle(4105700.0, 0.0003) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    