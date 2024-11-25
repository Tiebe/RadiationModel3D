using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine123 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine123";
        public override double halfLife { get; } = 47602.8d;
        public override double atomicWeight { get; } = 122.90559d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony123() }, { 1.0d, new BetaParticle(1, 639950.0) }, { 0.836d, new GammaParticle(159000.0, 0.0078) }, { 8e-06d, new GammaParticle(174200.0, 0.00712) }, { 0.00013d, new GammaParticle(182620.0, 0.00679) }, { 5e-06d, new GammaParticle(190700.0, 0.0065) }, { 0.000177d, new GammaParticle(192180.0, 0.00645) }, { 3.3e-06d, new GammaParticle(197230.0, 0.00629) }, { 3.3e-05d, new GammaParticle(198230.0, 0.00625) }, { 3.3e-05d, new GammaParticle(206800.0, 0.006) }, { 1.1000000000000001e-05d, new GammaParticle(207800.0, 0.00597) }, { 0.000693d, new GammaParticle(247970.0, 0.005) }, { 1.5e-05d, new GammaParticle(257510.0, 0.00481) }, { 9e-06d, new GammaParticle(259000.0, 0.00479) }, { 2.3e-05d, new GammaParticle(278360.0, 0.00445) }, { 0.0007199999999999999d, new GammaParticle(281030.0, 0.00441) }, { 4.3e-05d, new GammaParticle(285320.0, 0.00435) }, { 1.588e-05d, new GammaParticle(295190.0, 0.0042) }, { 2.6e-05d, new GammaParticle(329380.0, 0.00376) }, { 0.00011599999999999999d, new GammaParticle(330700.0, 0.00375) }, { 4.3e-05d, new GammaParticle(343730.0, 0.00361) }, { 0.0012d, new GammaParticle(346360.0, 0.00358) }, { 2.7000000000000002e-05d, new GammaParticle(405020.0, 0.00306) }, { 8e-06d, new GammaParticle(437500.0, 0.00283) }, { 0.00388d, new GammaParticle(440020.0, 0.00282) }, { 3.4e-05d, new GammaParticle(454760.0, 0.00273) }, { 0.0028799999999999997d, new GammaParticle(505330.0, 0.00245) }, { 0.0127d, new GammaParticle(528970.0, 0.00234) }, { 0.0031d, new GammaParticle(538540.0, 0.0023) }, { 2.5e-05d, new GammaParticle(556050.0, 0.00223) }, { 9e-06d, new GammaParticle(562790.0, 0.0022) }, { 5.852e-05d, new GammaParticle(574000.0, 0.00216) }, { 1.6e-05d, new GammaParticle(578260.0, 0.00214) }, { 2.6e-05d, new GammaParticle(599690.0, 0.00207) }, { 1.1000000000000001e-05d, new GammaParticle(610050.0, 0.00203) }, { 0.00078d, new GammaParticle(624580.0, 0.00199) }, { 1.6e-05d, new GammaParticle(628260.0, 0.00197) }, { 0.000268d, new GammaParticle(687940.0, 0.0018) }, { 0.00047d, new GammaParticle(735870.0, 0.00168) }, { 6.300000000000001e-06d, new GammaParticle(760850.0, 0.00163) }, { 0.00053d, new GammaParticle(783600.0, 0.00158) }, { 4.7e-06d, new GammaParticle(837100.0, 0.00148) }, { 7.2000000000000005e-06d, new GammaParticle(877520.0, 0.00141) }, { 7e-06d, new GammaParticle(894800.0, 0.00139) }, { 5.999999999999999e-06d, new GammaParticle(898200.0, 0.00138) }, { 1.3e-05d, new GammaParticle(909120.0, 0.00136) }, { 7.699999999999999e-06d, new GammaParticle(1036630.0, 0.0012) }, { 1.21e-05d, new GammaParticle(1068120.0, 0.00116) }, { 0.08961888674986705d, new GammaParticle(4135.0, 0.29984) }, { 0.24627375932819576d, new GammaParticle(27202.0, 0.04558) }, { 0.45861035256647253d, new GammaParticle(27473.0, 0.04513) }, { 0.13124629396493986d, new GammaParticle(31093.0, 0.03988) }, { 0.15972673975533183d, new GammaParticle(31359.0, 0.03954) }, { 0.02848044579039195d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    