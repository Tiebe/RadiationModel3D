using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum140 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum140";
        public override double halfLife { get; } = 145029.312d;
        public override double atomicWeight { get; } = 139.90949d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium140() }, { 1.0d, new BetaParticle(-1, 1881050.0) }, { 2.862e-05d, new GammaParticle(24595.0, 0.05041) }, { 0.0001431d, new GammaParticle(64135.0, 0.01933) }, { 0.0007536600000000001d, new GammaParticle(68916.0, 0.01799) }, { 0.0021942d, new GammaParticle(109422.0, 0.01133) }, { 0.0046746d, new GammaParticle(131117.0, 0.00946) }, { 0.00126882d, new GammaParticle(173543.0, 0.00714) }, { 0.00414036d, new GammaParticle(241933.0, 0.00512) }, { 0.00465552d, new GammaParticle(266543.0, 0.00465) }, { 0.00024804d, new GammaParticle(306900.0, 0.00404) }, { 0.203202d, new GammaParticle(328762.0, 0.00377) }, { 0.00073458d, new GammaParticle(397520.0, 0.00312) }, { 0.029001600000000002d, new GammaParticle(432493.0, 0.00287) }, { 0.00039114000000000005d, new GammaParticle(438500.0, 0.00283) }, { 2.862e-05d, new GammaParticle(445500.0, 0.00278) }, { 0.455058d, new GammaParticle(487021.0, 0.00255) }, { 0.00037206d, new GammaParticle(618120.0, 0.00201) }, { 0.0433116d, new GammaParticle(751637.0, 0.00165) }, { 0.23277599999999998d, new GammaParticle(815772.0, 0.00152) }, { 0.0550458d, new GammaParticle(867846.0, 0.00143) }, { 0.0266166d, new GammaParticle(919550.0, 0.00135) }, { 0.0689742d, new GammaParticle(925189.0, 0.00134) }, { 0.00518976d, new GammaParticle(950987.0, 0.0013) }, { 0.00013356d, new GammaParticle(992900.0, 0.00125) }, { 0.00024804d, new GammaParticle(1045050.0, 0.00119) }, { 0.00022896d, new GammaParticle(1097200.0, 0.00113) }, { 0.00041976d, new GammaParticle(1303500.0, 0.00095) }, { 0.00059148d, new GammaParticle(1405200.0, 0.00088) }, { 0.9540000000000001d, new GammaParticle(1596210.0, 0.00078) }, { 0.00041022000000000004d, new GammaParticle(1877290.0, 0.00066) }, { 0.00013356d, new GammaParticle(1924620.0, 0.00064) }, { 0.000115434d, new GammaParticle(2083200.0, 0.0006) }, { 0.008490600000000001d, new GammaParticle(2347880.0, 0.00053) }, { 0.00011448d, new GammaParticle(2464100.0, 0.0005) }, { 0.0346302d, new GammaParticle(2521400.0, 0.00049) }, { 0.00101124d, new GammaParticle(2547340.0, 0.00049) }, { 0.0006678000000000001d, new GammaParticle(2899610.0, 0.00043) }, { 0.00024804d, new GammaParticle(3118510.0, 0.0004) }, { 3.816e-05d, new GammaParticle(3320400.0, 0.00037) }, { 0.0039000000000000003d, new GammaParticle(5410.0, 0.22918) }, { 0.005836925385786633d, new GammaParticle(34279.0, 0.03617) }, { 0.010690339534407754d, new GammaParticle(34720.0, 0.03571) }, { 0.003219785342905494d, new GammaParticle(39366.0, 0.0315) }, { 0.004037610820003489d, new GammaParticle(39753.0, 0.03119) }, { 0.0008178254770979955d, new GammaParticle(40229.0, 0.03082) } } },

        };
    }
}
    