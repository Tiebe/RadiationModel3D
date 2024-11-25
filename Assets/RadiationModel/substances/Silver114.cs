using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver114 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver114";
        public override double halfLife { get; } = 4.6d;
        public override double atomicWeight { get; } = 113.90882d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium114() }, { 1.0d, new BetaParticle(-1, 2541965.0) }, { 0.0010199999999999999d, new GammaParticle(495570.0, 0.0025) }, { 0.204d, new GammaParticle(558450.0, 0.00222) }, { 0.017748d, new GammaParticle(576100.0, 0.00215) }, { 0.008772d, new GammaParticle(651290.0, 0.0019) }, { 0.0008364000000000001d, new GammaParticle(707540.0, 0.00175) }, { 0.0004284d, new GammaParticle(725300.0, 0.00171) }, { 0.0003264d, new GammaParticle(742600.0, 0.00167) }, { 0.00010200000000000001d, new GammaParticle(747400.0, 0.00166) }, { 0.004896d, new GammaParticle(805880.0, 0.00154) }, { 0.003468d, new GammaParticle(811340.0, 0.00153) }, { 0.00040800000000000005d, new GammaParticle(1004800.0, 0.00123) }, { 0.002244d, new GammaParticle(1189370.0, 0.00104) }, { 0.003876d, new GammaParticle(1209700.0, 0.00102) }, { 0.0004284d, new GammaParticle(1219300.0, 0.00102) }, { 0.0016524d, new GammaParticle(1283400.0, 0.00097) }, { 0.013056000000000002d, new GammaParticle(1301230.0, 0.00095) }, { 0.004692d, new GammaParticle(1364350.0, 0.00091) }, { 0.0010404d, new GammaParticle(1397000.0, 0.00089) }, { 0.0014892d, new GammaParticle(1425600.0, 0.00087) }, { 0.0019788d, new GammaParticle(1489800.0, 0.00083) }, { 0.007344000000000001d, new GammaParticle(1660380.0, 0.00075) }, { 0.000714d, new GammaParticle(1802600.0, 0.00069) }, { 0.0010199999999999999d, new GammaParticle(1842790.0, 0.00067) }, { 0.000612d, new GammaParticle(1842800.0, 0.00067) }, { 0.0006324000000000001d, new GammaParticle(1903500.0, 0.00065) }, { 0.0007956d, new GammaParticle(1957500.0, 0.00063) }, { 0.01224d, new GammaParticle(1995630.0, 0.00062) }, { 0.0009996d, new GammaParticle(2079300.0, 0.0006) }, { 0.0010199999999999999d, new GammaParticle(2103100.0, 0.00059) }, { 0.001428d, new GammaParticle(2136950.0, 0.00058) }, { 0.0003468d, new GammaParticle(2372500.0, 0.00052) }, { 0.0006528d, new GammaParticle(2393900.0, 0.00052) }, { 0.0036720000000000004d, new GammaParticle(2455760.0, 0.0005) }, { 0.0013464000000000002d, new GammaParticle(2608310.0, 0.00048) }, { 0.0005099999999999999d, new GammaParticle(2702700.0, 0.00046) }, { 0.0005916d, new GammaParticle(2757200.0, 0.00045) }, { 0.0010608d, new GammaParticle(2792300.0, 0.00044) }, { 0.0005304d, new GammaParticle(2800300.0, 0.00044) }, { 0.0013872d, new GammaParticle(2942560.0, 0.00042) }, { 0.0008772000000000001d, new GammaParticle(3213200.0, 0.00039) } } },

        };
    }
}
    