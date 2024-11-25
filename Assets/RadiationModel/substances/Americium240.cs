using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium240";
        public override double halfLife { get; } = 182880.0d;
        public override double atomicWeight { get; } = 240.0553d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium240() }, { 0.00109446d, new GammaParticle(42870.0, 0.02892) }, { 0.014691399999999999d, new GammaParticle(98900.0, 0.01254) }, { 0.00011832d, new GammaParticle(152400.0, 0.00814) }, { 0.00019720000000000002d, new GammaParticle(249700.0, 0.00497) }, { 4.9300000000000006e-05d, new GammaParticle(251800.0, 0.00492) }, { 8.874e-05d, new GammaParticle(303700.0, 0.00408) }, { 0.00048314d, new GammaParticle(343700.0, 0.00361) }, { 0.00052258d, new GammaParticle(382100.0, 0.00324) }, { 0.00012817999999999998d, new GammaParticle(447800.0, 0.00277) }, { 0.00070992d, new GammaParticle(507900.0, 0.00244) }, { 9.860000000000001e-05d, new GammaParticle(555400.0, 0.00223) }, { 5.916e-05d, new GammaParticle(597400.0, 0.00208) }, { 0.00013804d, new GammaParticle(600700.0, 0.00206) }, { 0.0006902d, new GammaParticle(606700.0, 0.00204) }, { 0.0003451d, new GammaParticle(697800.0, 0.00178) }, { 0.00010352999999999999d, new GammaParticle(758610.0, 0.00163) }, { 3.9439999999999995e-05d, new GammaParticle(857480.0, 0.00145) }, { 0.247d, new GammaParticle(888850.0, 0.00139) }, { 1.479e-05d, new GammaParticle(900370.0, 0.00138) }, { 0.0008874d, new GammaParticle(916100.0, 0.00135) }, { 0.0002465d, new GammaParticle(934600.0, 0.00133) }, { 6.902e-05d, new GammaParticle(938000.0, 0.00132) }, { 0.00038454d, new GammaParticle(959300.0, 0.00129) }, { 0.722d, new GammaParticle(987790.0, 0.00126) }, { 9.860000000000001e-05d, new GammaParticle(1033500.0, 0.0012) }, { 0.00015775999999999998d, new GammaParticle(1036100.0, 0.0012) }, { 3.0566e-05d, new GammaParticle(1089800.0, 0.00114) }, { 0.00015775999999999998d, new GammaParticle(1094700.0, 0.00113) }, { 0.00010846d, new GammaParticle(1120300.0, 0.00111) }, { 0.00048314d, new GammaParticle(1135100.0, 0.00109) }, { 7.1978e-05d, new GammaParticle(1137400.0, 0.00109) }, { 0.000100572d, new GammaParticle(1180300.0, 0.00105) }, { 4.929999999999999e-06d, new GammaParticle(1190000.0, 0.00104) }, { 2.5636e-05d, new GammaParticle(1195500.0, 0.00104) }, { 0.0003451d, new GammaParticle(1219300.0, 0.00102) }, { 6.902e-05d, new GammaParticle(1223000.0, 0.00101) }, { 8.874e-05d, new GammaParticle(1294100.0, 0.00096) }, { 0.87d, new GammaParticle(17604.0, 0.07043) }, { 0.187d, new GammaParticle(99533.0, 0.01246) }, { 0.29600000000000004d, new GammaParticle(103741.0, 0.01195) }, { 0.109d, new GammaParticle(117130.0, 0.01059) }, { 0.146d, new GammaParticle(118619.0, 0.01045) }, { 0.0377d, new GammaParticle(120544.0, 0.01029) } } },
            { 1.9e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium236() }, { 1.0d, new AlphaParticle(6727002.09) } } },

        };
    }
}
    