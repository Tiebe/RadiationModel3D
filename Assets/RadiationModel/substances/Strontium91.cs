using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium91";
        public override double halfLife { get; } = 34740.0d;
        public override double atomicWeight { get; } = 90.9102d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium91() }, { 1.0d, new BetaParticle(-1, 1349650.0) }, { 0.000737d, new GammaParticle(118500.0, 0.01046) }, { 0.004489d, new GammaParticle(261200.0, 0.00475) }, { 0.002613d, new GammaParticle(272600.0, 0.00455) }, { 0.0103515d, new GammaParticle(274700.0, 0.00451) }, { 0.0005025d, new GammaParticle(359100.0, 0.00345) }, { 0.001474d, new GammaParticle(379900.0, 0.00326) }, { 0.0005025d, new GammaParticle(393000.0, 0.00315) }, { 0.000804d, new GammaParticle(486500.0, 0.00255) }, { 0.00043549999999999996d, new GammaParticle(506700.0, 0.00245) }, { 0.000335d, new GammaParticle(520800.0, 0.00238) }, { 0.0007704999999999999d, new GammaParticle(533900.0, 0.00232) }, { 0.0009379999999999999d, new GammaParticle(593100.0, 0.00209) }, { 0.017755d, new GammaParticle(620100.0, 0.002) }, { 0.00043549999999999996d, new GammaParticle(626800.0, 0.00198) }, { 0.005561d, new GammaParticle(631300.0, 0.00196) }, { 0.029815d, new GammaParticle(652300.0, 0.0019) }, { 0.08039999999999999d, new GammaParticle(652900.0, 0.0019) }, { 0.003685d, new GammaParticle(653000.0, 0.0019) }, { 0.001005d, new GammaParticle(660900.0, 0.00188) }, { 0.236845d, new GammaParticle(749800.0, 0.00165) }, { 0.005762000000000001d, new GammaParticle(761400.0, 0.00163) }, { 0.0006365d, new GammaParticle(793600.0, 0.00156) }, { 0.001608d, new GammaParticle(820800.0, 0.00151) }, { 0.00067d, new GammaParticle(823700.0, 0.00151) }, { 0.0018759999999999998d, new GammaParticle(879700.0, 0.00141) }, { 0.0007034999999999999d, new GammaParticle(892900.0, 0.00139) }, { 0.0009379999999999999d, new GammaParticle(901300.0, 0.00138) }, { 0.038525000000000004d, new GammaParticle(925800.0, 0.00134) }, { 0.000402d, new GammaParticle(973900.0, 0.00127) }, { 0.00043549999999999996d, new GammaParticle(992200.0, 0.00125) }, { 0.335d, new GammaParticle(1024300.0, 0.00121) }, { 0.0022445d, new GammaParticle(1054600.0, 0.00118) }, { 0.001273d, new GammaParticle(1140800.0, 0.00109) }, { 0.0093465d, new GammaParticle(1280900.0, 0.00097) }, { 0.0001675d, new GammaParticle(1305300.0, 0.00095) }, { 0.000402d, new GammaParticle(1327400.0, 0.00093) }, { 0.00023449999999999998d, new GammaParticle(1353500.0, 0.00092) }, { 0.0098155d, new GammaParticle(1413400.0, 0.00088) }, { 0.001675d, new GammaParticle(1473800.0, 0.00084) }, { 0.000134d, new GammaParticle(1486400.0, 0.00083) }, { 0.00067d, new GammaParticle(1545900.0, 0.0008) }, { 0.0001675d, new GammaParticle(1553600.0, 0.0008) }, { 0.000134d, new GammaParticle(1626800.0, 0.00076) }, { 3.0149999999999998e-05d, new GammaParticle(1646000.0, 0.00075) }, { 0.0029145d, new GammaParticle(1651400.0, 0.00075) }, { 0.001608d, new GammaParticle(1724000.0, 0.00072) }, { 4.02e-05d, new GammaParticle(2016000.0, 0.00062) }, { 4.355e-05d, new GammaParticle(2412300.0, 0.00051) }, { 2.4088822385088e-05d, new GammaParticle(2027.0, 0.61166) }, { 0.00014443619123045078d, new GammaParticle(14883.0, 0.08331) }, { 0.00027696297455503504d, new GammaParticle(14958.0, 0.08289) }, { 6.954197129570672e-05d, new GammaParticle(16803.0, 0.07379) }, { 7.913876333451425e-05d, new GammaParticle(16880.0, 0.07345) }, { 9.596792038807527e-06d, new GammaParticle(17011.0, 0.07288) } } },

        };
    }
}
    