using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium241";
        public override double halfLife { get; } = 452179192.28993d;
        public override double atomicWeight { get; } = 241.05685d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9999800000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium241() }, { 1.0d, new BetaParticle(-1, 10399.99999) } } },
            { 2.47e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium237() }, { 1.0d, new AlphaParticle(6162002.09) }, { 4.165e-08d, new GammaParticle(44200.0, 0.02805) }, { 8.33e-09d, new GammaParticle(44860.0, 0.02764) }, { 2.499e-08d, new GammaParticle(56320.0, 0.02201) }, { 9.8e-09d, new GammaParticle(56760.0, 0.02184) }, { 2.87e-08d, new GammaParticle(71600.0, 0.01732) }, { 2.06e-07d, new GammaParticle(77100.0, 0.01608) }, { 7.109999999999999e-10d, new GammaParticle(101000.0, 0.01228) }, { 1.012e-06d, new GammaParticle(103680.0, 0.01196) }, { 8.100000000000001e-07d, new GammaParticle(114000.0, 0.01088) }, { 6.86e-09d, new GammaParticle(121200.0, 0.01023) }, { 1.86e-06d, new GammaParticle(148567.0, 0.00835) }, { 6.54e-08d, new GammaParticle(159955.0, 0.00775) }, { 1.24597035816e-05d, new GammaParticle(16678.0, 0.07434) }, { 3.1785362468885805e-06d, new GammaParticle(94657.0, 0.0131) }, { 5.088100283157644e-06d, new GammaParticle(98439.0, 0.0126) }, { 1.8356614649432e-06d, new GammaParticle(111238.0, 0.01115) }, { 2.4634576859537747e-06d, new GammaParticle(112645.0, 0.01101) }, { 6.277962210105744e-07d, new GammaParticle(114446.0, 0.01083) } } },
            { 2.4e-16d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    