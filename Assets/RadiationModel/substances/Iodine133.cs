using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine133 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine133";
        public override double halfLife { get; } = 74988.0d;
        public override double atomicWeight { get; } = 132.90783d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon133() }, { 1.0d, new BetaParticle(-1, 893300.0) }, { 0.0002958d, new GammaParticle(150390.0, 0.00824) }, { 0.000783d, new GammaParticle(176970.0, 0.00701) }, { 4.35e-05d, new GammaParticle(203700.0, 0.00609) }, { 0.0029406d, new GammaParticle(233221.0, 0.00532) }, { 0.000348d, new GammaParticle(245950.0, 0.00504) }, { 0.0035931d, new GammaParticle(262702.0, 0.00472) }, { 0.0011745d, new GammaParticle(267173.0, 0.00464) }, { 0.001044d, new GammaParticle(345430.0, 0.00359) }, { 0.001131d, new GammaParticle(361090.0, 0.00343) }, { 9.570000000000001e-05d, new GammaParticle(372050.0, 0.00333) }, { 0.00045240000000000005d, new GammaParticle(381590.0, 0.00325) }, { 0.0005916d, new GammaParticle(386850.0, 0.0032) }, { 0.0015398999999999999d, new GammaParticle(417560.0, 0.00297) }, { 0.0031146000000000004d, new GammaParticle(422910.0, 0.00293) }, { 0.0004002d, new GammaParticle(438870.0, 0.00283) }, { 8.7e-05d, new GammaParticle(509800.0, 0.00243) }, { 0.018269999999999998d, new GammaParticle(510530.0, 0.00243) }, { 0.0008699999999999999d, new GammaParticle(522400.0, 0.00237) }, { 0.87d, new GammaParticle(529872.0, 0.00234) }, { 0.0003567d, new GammaParticle(537730.0, 0.00231) }, { 8.7e-06d, new GammaParticle(554500.0, 0.00224) }, { 0.0002001d, new GammaParticle(556170.0, 0.00223) }, { 3.48e-05d, new GammaParticle(567100.0, 0.00219) }, { 0.0054375d, new GammaParticle(617974.0, 0.00201) }, { 0.0005655d, new GammaParticle(648760.0, 0.00191) }, { 0.0004263d, new GammaParticle(670100.0, 0.00185) }, { 0.00021749999999999997d, new GammaParticle(678650.0, 0.00183) }, { 0.006498899999999999d, new GammaParticle(680247.0, 0.00182) }, { 0.015051000000000002d, new GammaParticle(706578.0, 0.00175) }, { 0.0046023d, new GammaParticle(768382.0, 0.00161) }, { 0.0005046d, new GammaParticle(789590.0, 0.00157) }, { 0.0015486d, new GammaParticle(820506.0, 0.00151) }, { 0.012441d, new GammaParticle(856278.0, 0.00145) }, { 0.045065999999999995d, new GammaParticle(875329.0, 0.00142) }, { 0.0021402d, new GammaParticle(909670.0, 0.00136) }, { 0.0004611d, new GammaParticle(911490.0, 0.00136) }, { 6.0899999999999996e-05d, new GammaParticle(1018100.0, 0.00122) }, { 8.7e-05d, new GammaParticle(1035580.0, 0.0012) }, { 0.0055593000000000005d, new GammaParticle(1052296.0, 0.00118) }, { 0.0013833d, new GammaParticle(1060070.0, 0.00117) }, { 0.00012179999999999999d, new GammaParticle(1087710.0, 0.00114) }, { 0.015051000000000002d, new GammaParticle(1236441.0, 0.001) }, { 0.02349d, new GammaParticle(1298223.0, 0.00096) }, { 4.35e-06d, new GammaParticle(1327200.0, 0.00093) }, { 0.0014964d, new GammaParticle(1350380.0, 0.00092) }, { 8.7e-05d, new GammaParticle(1386150.0, 0.00089) }, { 2.958e-05d, new GammaParticle(1589940.0, 0.00078) }, { 0.00298d, new GammaParticle(4540.0, 0.27309) }, { 0.0066d, new GammaParticle(29458.0, 0.04209) }, { 0.012199999999999999d, new GammaParticle(29778.0, 0.04164) }, { 0.0035499999999999998d, new GammaParticle(33726.0, 0.03676) }, { 0.00439d, new GammaParticle(34030.0, 0.03643) }, { 0.00084d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    