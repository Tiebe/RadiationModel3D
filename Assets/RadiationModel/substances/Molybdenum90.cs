using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum90 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum90";
        public override double halfLife { get; } = 20016.0d;
        public override double atomicWeight { get; } = 89.91393d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium90() }, { 1.0d, new BetaParticle(1, 4299775.0) }, { 2.0000000000000002e-11d, new GammaParticle(2300.0, 0.53906) }, { 0.021671999999999997d, new GammaParticle(42700.0, 0.02904) }, { 0.64242d, new GammaParticle(122370.0, 0.01013) }, { 0.059598000000000005d, new GammaParticle(162930.0, 0.00761) }, { 0.063468d, new GammaParticle(203130.0, 0.0061) }, { 0.774d, new GammaParticle(257340.0, 0.00482) }, { 0.062694d, new GammaParticle(323200.0, 0.00384) }, { 0.0024768d, new GammaParticle(421000.0, 0.00294) }, { 0.0035604d, new GammaParticle(425100.0, 0.00292) }, { 0.009288d, new GammaParticle(440500.0, 0.00281) }, { 0.059598000000000005d, new GammaParticle(445370.0, 0.00278) }, { 0.0141642d, new GammaParticle(472200.0, 0.00263) }, { 0.0072756d, new GammaParticle(489800.0, 0.00253) }, { 0.001548d, new GammaParticle(517700.0, 0.00239) }, { 0.054954d, new GammaParticle(941500.0, 0.00132) }, { 0.006966d, new GammaParticle(946400.0, 0.00131) }, { 0.0013932d, new GammaParticle(987300.0, 0.00126) }, { 0.0101394d, new GammaParticle(990200.0, 0.00125) }, { 0.041021999999999996d, new GammaParticle(1271300.0, 0.00098) }, { 0.018576d, new GammaParticle(1387400.0, 0.00089) }, { 0.0004644d, new GammaParticle(1446000.0, 0.00086) }, { 0.018576d, new GammaParticle(1454600.0, 0.00085) }, { 0.006966d, new GammaParticle(1463500.0, 0.00085) }, { 0.002322d, new GammaParticle(1481600.0, 0.00084) }, { 0.5d, new GammaParticle(511000.0, 0.00243) }, { 0.045381919930565534d, new GammaParticle(2299.0, 0.5393) }, { 0.23796515071133598d, new GammaParticle(16521.0, 0.07505) }, { 0.4544788974624446d, new GammaParticle(16615.0, 0.07462) }, { 0.11759506313768639d, new GammaParticle(18694.0, 0.06632) }, { 0.13523432260833934d, new GammaParticle(18795.0, 0.06597) }, { 0.01763925947065296d, new GammaParticle(18951.0, 0.06542) } } },

        };
    }
}
    