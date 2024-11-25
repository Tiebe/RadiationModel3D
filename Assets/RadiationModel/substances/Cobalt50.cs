using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt50 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt50";
        public override double halfLife { get; } = 0.0388d;
        public override double atomicWeight { get; } = 49.98112d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese50() }, { 1.0d, new BetaParticle(1, 12518445.0) }, { 0.24d, new GammaParticle(764800.0, 0.00162) }, { 0.11d, new GammaParticle(1086600.0, 0.00114) }, { 0.15d, new GammaParticle(1307800.0, 0.00095) }, { 1.1420000000000001d, new GammaParticle(511000.0, 0.00243) }, { 3.2182419540000003e-06d, new GammaParticle(728.0, 1.70308) }, { 3.646283883648505e-05d, new GammaParticle(6391.0, 0.194) }, { 7.1397765491453e-05d, new GammaParticle(6404.0, 0.1936) }, { 1.4755330672061927e-05d, new GammaParticle(7082.0, 0.17507) }, { 1.4755330672061927e-05d, new GammaParticle(7082.0, 0.17507) } } },
            { 0.705d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese49() }, { 1.0d, new ProtonParticle() }, { 0.64d, new GammaParticle(261400.0, 0.00474) }, { 0.235d, new GammaParticle(482200.0, 0.00257) }, { 0.27d, new GammaParticle(797300.0, 0.00156) }, { 0.016d, new GammaParticle(939500.0, 0.00132) }, { 0.024d, new GammaParticle(1058700.0, 0.00117) }, { 0.16d, new GammaParticle(1278400.0, 0.00097) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    