using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium165m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium165m";
        public override double halfLife { get; } = 75.42d;
        public override double atomicWeight { get; } = 164.93183d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9773000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium165() }, { 0.0305d, new GammaParticle(108160.0, 0.01146) }, { 0.1424542455d, new GammaParticle(7384.0, 0.16791) }, { 0.026490297095108698d, new GammaParticle(45207.0, 0.02743) }, { 0.047337914751802525d, new GammaParticle(45998.0, 0.02695) }, { 0.015199236629435533d, new GammaParticle(52220.0, 0.02374) }, { 0.01915103815308877d, new GammaParticle(52791.0, 0.02349) }, { 0.003951801523653238d, new GammaParticle(53478.0, 0.02318) } } },
            { 0.0227d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium165() }, { 1.0d, new BetaParticle(-1, 696950.0) }, { 6e-05d, new GammaParticle(30000.0, 0.04133) }, { 8.3e-05d, new GammaParticle(57800.0, 0.02145) }, { 0.00012d, new GammaParticle(67900.0, 0.01826) }, { 0.000113d, new GammaParticle(87700.0, 0.01414) }, { 1.1000000000000001e-05d, new GammaParticle(89700.0, 0.01382) }, { 0.0004d, new GammaParticle(95960.0, 0.01292) }, { 2.1000000000000002e-06d, new GammaParticle(109600.0, 0.01131) }, { 2.8e-05d, new GammaParticle(119500.0, 0.01038) }, { 0.00247d, new GammaParticle(153803.0, 0.00806) }, { 0.000184d, new GammaParticle(251730.0, 0.00493) }, { 0.00545d, new GammaParticle(361471.0, 0.00343) }, { 0.015600000000000001d, new GammaParticle(515467.0, 0.00241) }, { 4.6e-06d, new GammaParticle(676000.0, 0.00183) }, { 0.00086d, new GammaParticle(7656.0, 0.16194) }, { 0.0010066032794374615d, new GammaParticle(46700.0, 0.02655) }, { 0.0017927039705030482d, new GammaParticle(47547.0, 0.02608) }, { 0.000579190000047215d, new GammaParticle(53982.0, 0.02297) }, { 0.0007297794000594909d, new GammaParticle(54577.0, 0.02272) }, { 0.0001505894000122759d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    