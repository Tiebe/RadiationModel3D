using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold193m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold193m";
        public override double halfLife { get; } = 3.9d;
        public override double atomicWeight { get; } = 192.96445d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold193() }, { 1.0709999999999999e-05d, new GammaParticle(32210.0, 0.03849) }, { 0.00053d, new GammaParticle(38220.0, 0.03244) }, { 0.0385d, new GammaParticle(219750.0, 0.00564) }, { 0.671469d, new GammaParticle(257970.0, 0.00481) }, { 0.000262d, new GammaParticle(289800.0, 0.00428) }, { 0.33390019365948d, new GammaParticle(11419.0, 0.10858) }, { 0.06575905002158877d, new GammaParticle(66991.0, 0.01851) }, { 0.11194935311812866d, new GammaParticle(68806.0, 0.01802) }, { 0.03777509888307415d, new GammaParticle(78048.0, 0.01589) }, { 0.04869210246028257d, new GammaParticle(78983.0, 0.0157) }, { 0.010917003577208428d, new GammaParticle(80133.0, 0.01547) } } },
            { 0.0003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium193() }, { 1.0d, new BetaParticle(1, 710650.00001) }, { 2.9e-11d, new GammaParticle(1642.0, 0.75508) }, { 6.3e-10d, new GammaParticle(12634.0, 0.09814) }, { 1.0299999999999999e-10d, new GammaParticle(135400.0, 0.00916) }, { 4.858013187e-08d, new GammaParticle(11070.0, 0.112) }, { 2.39856465514037e-08d, new GammaParticle(65122.0, 0.01904) }, { 4.1001105216074705e-08d, new GammaParticle(66832.0, 0.01855) }, { 1.3795787894651325e-08d, new GammaParticle(75821.0, 0.01635) }, { 1.7741383232521605e-08d, new GammaParticle(76725.0, 0.01616) }, { 3.945595337870278e-09d, new GammaParticle(77832.0, 0.01593) } } },

        };
    }
}
    