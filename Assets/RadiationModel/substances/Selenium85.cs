using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium85";
        public override double halfLife { get; } = 32.9d;
        public override double atomicWeight { get; } = 84.92226d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine85() }, { 1.0d, new BetaParticle(-1, 3080700.0) }, { 0.46d, new GammaParticle(345200.0, 0.00359) }, { 0.02346d, new GammaParticle(432500.0, 0.00287) }, { 0.013340000000000001d, new GammaParticle(597400.0, 0.00208) }, { 0.02806d, new GammaParticle(609800.0, 0.00203) }, { 0.028980000000000002d, new GammaParticle(840900.0, 0.00147) }, { 0.0253d, new GammaParticle(941100.0, 0.00132) }, { 0.04232d, new GammaParticle(956200.0, 0.0013) }, { 0.01748d, new GammaParticle(987900.0, 0.00126) }, { 0.02484d, new GammaParticle(1082100.0, 0.00115) }, { 0.00874d, new GammaParticle(1191200.0, 0.00104) }, { 0.044160000000000005d, new GammaParticle(1207900.0, 0.00103) }, { 0.01564d, new GammaParticle(1246900.0, 0.00099) }, { 0.01518d, new GammaParticle(1373400.0, 0.0009) }, { 0.07038d, new GammaParticle(1427200.0, 0.00087) }, { 0.01794d, new GammaParticle(1450100.0, 0.00086) }, { 0.00828d, new GammaParticle(1552800.0, 0.0008) }, { 0.00966d, new GammaParticle(1599000.0, 0.00078) }, { 0.02116d, new GammaParticle(1701000.0, 0.00073) }, { 0.02714d, new GammaParticle(1724500.0, 0.00072) }, { 0.00874d, new GammaParticle(1795300.0, 0.00069) }, { 0.011040000000000001d, new GammaParticle(1944000.0, 0.00064) }, { 0.01012d, new GammaParticle(2029400.0, 0.00061) }, { 0.0069d, new GammaParticle(2091200.0, 0.00059) }, { 0.02944d, new GammaParticle(2234400.0, 0.00055) }, { 0.0027600000000000003d, new GammaParticle(2245600.0, 0.00055) }, { 0.005520000000000001d, new GammaParticle(2304000.0, 0.00054) }, { 0.022080000000000002d, new GammaParticle(2417300.0, 0.00051) }, { 0.0046d, new GammaParticle(2446900.0, 0.00051) }, { 0.022080000000000002d, new GammaParticle(2455100.0, 0.00051) }, { 0.00736d, new GammaParticle(2542900.0, 0.00049) }, { 0.0161d, new GammaParticle(2550200.0, 0.00049) }, { 0.00966d, new GammaParticle(2565400.0, 0.00048) }, { 0.0184d, new GammaParticle(2584300.0, 0.00048) }, { 0.01472d, new GammaParticle(2601500.0, 0.00048) }, { 0.0069d, new GammaParticle(2724500.0, 0.00046) }, { 0.00644d, new GammaParticle(2871900.0, 0.00043) }, { 0.03036d, new GammaParticle(3007700.0, 0.00041) }, { 0.00828d, new GammaParticle(3172200.0, 0.00039) }, { 0.07406d, new GammaParticle(3396600.0, 0.00037) }, { 0.0069d, new GammaParticle(3479300.0, 0.00036) }, { 0.01288d, new GammaParticle(3539300.0, 0.00035) }, { 0.00506d, new GammaParticle(3555000.0, 0.00035) }, { 0.01058d, new GammaParticle(3625200.0, 0.00034) }, { 0.03818d, new GammaParticle(3655900.0, 0.00034) }, { 0.023d, new GammaParticle(3683800.0, 0.00034) }, { 0.0069d, new GammaParticle(3741400.0, 0.00033) }, { 0.02944d, new GammaParticle(3774500.0, 0.00033) }, { 0.011040000000000001d, new GammaParticle(3827100.0, 0.00032) }, { 0.00782d, new GammaParticle(3954800.0, 0.00031) }, { 4.709980112e-05d, new GammaParticle(1535.0, 0.80771) }, { 0.0003476750507977794d, new GammaParticle(11879.0, 0.10437) }, { 0.0006710578089129114d, new GammaParticle(11925.0, 0.10397) }, { 0.00015916518779178357d, new GammaParticle(13345.0, 0.09291) }, { 0.00017145274028930926d, new GammaParticle(13377.0, 0.09268) }, { 1.2287552497525694e-05d, new GammaParticle(13469.0, 0.09205) } } },

        };
    }
}
    