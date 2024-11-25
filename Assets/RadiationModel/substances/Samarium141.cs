using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium141";
        public override double halfLife { get; } = 612.0d;
        public override double atomicWeight { get; } = 140.91848d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium141() }, { 1.0d, new BetaParticle(1, 4129000.0) }, { 0.025099999999999997d, new GammaParticle(324400.0, 0.00382) }, { 0.425d, new GammaParticle(403900.0, 0.00307) }, { 0.377d, new GammaParticle(438200.0, 0.00283) }, { 0.0128d, new GammaParticle(728400.0, 0.0017) }, { 0.0115d, new GammaParticle(767500.0, 0.00162) }, { 0.0132d, new GammaParticle(854300.0, 0.00145) }, { 0.0064d, new GammaParticle(888500.0, 0.0014) }, { 0.0149d, new GammaParticle(1046400.0, 0.00118) }, { 0.032799999999999996d, new GammaParticle(1057100.0, 0.00117) }, { 0.0259d, new GammaParticle(1091900.0, 0.00114) }, { 0.068d, new GammaParticle(1292600.0, 0.00096) }, { 0.0051d, new GammaParticle(1336500.0, 0.00093) }, { 0.0038d, new GammaParticle(1352700.0, 0.00092) }, { 0.003d, new GammaParticle(1446600.0, 0.00086) }, { 0.019d, new GammaParticle(1463900.0, 0.00085) }, { 0.0051d, new GammaParticle(1481000.0, 0.00084) }, { 0.0179d, new GammaParticle(1495700.0, 0.00083) }, { 0.006d, new GammaParticle(1499100.0, 0.00083) }, { 0.0068000000000000005d, new GammaParticle(1515300.0, 0.00082) }, { 0.0021d, new GammaParticle(1565900.0, 0.00079) }, { 0.0026d, new GammaParticle(1587900.0, 0.00078) }, { 0.006d, new GammaParticle(1599900.0, 0.00077) }, { 0.04d, new GammaParticle(1600700.0, 0.00077) }, { 0.0034000000000000002d, new GammaParticle(1634100.0, 0.00076) }, { 0.0072d, new GammaParticle(1885000.0, 0.00066) }, { 0.0089d, new GammaParticle(1902400.0, 0.00065) }, { 0.0068000000000000005d, new GammaParticle(1992300.0, 0.00062) }, { 0.0089d, new GammaParticle(2004800.0, 0.00062) }, { 0.0281d, new GammaParticle(2037800.0, 0.00061) }, { 1.0695999999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.060555184944439996d, new GammaParticle(6109.0, 0.20295) }, { 0.10659980016751007d, new GammaParticle(38171.0, 0.03248) }, { 0.19353631112474595d, new GammaParticle(38724.0, 0.03202) }, { 0.06000334508173743d, new GammaParticle(43934.0, 0.02822) }, { 0.07542420476774395d, new GammaParticle(44387.0, 0.02793) }, { 0.015420859686006521d, new GammaParticle(44938.0, 0.02759) } } },

        };
    }
}
    