using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium135";
        public override double halfLife { get; } = 19.0d;
        public override double atomicWeight { get; } = 134.91655d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine135() }, { 1.0d, new BetaParticle(-1, 3025200.0) }, { 0.001116d, new GammaParticle(139500.0, 0.00889) }, { 0.0004185d, new GammaParticle(174800.0, 0.00709) }, { 0.07812000000000001d, new GammaParticle(266870.0, 0.00465) }, { 0.001116d, new GammaParticle(312600.0, 0.00397) }, { 0.00039059999999999995d, new GammaParticle(407400.0, 0.00304) }, { 0.0011439d, new GammaParticle(455600.0, 0.00272) }, { 0.27899999999999997d, new GammaParticle(603700.0, 0.00205) }, { 0.0006696d, new GammaParticle(647300.0, 0.00192) }, { 0.058311d, new GammaParticle(870300.0, 0.00142) }, { 0.0007811999999999999d, new GammaParticle(912400.0, 0.00136) }, { 0.0007811999999999999d, new GammaParticle(1009800.0, 0.00123) }, { 0.002232d, new GammaParticle(1107000.0, 0.00112) }, { 0.013113d, new GammaParticle(1133300.0, 0.00109) }, { 0.006696d, new GammaParticle(1183900.0, 0.00105) }, { 0.0029853d, new GammaParticle(1198600.0, 0.00103) }, { 0.0010044d, new GammaParticle(1253300.0, 0.00099) }, { 0.0015345d, new GammaParticle(1336600.0, 0.00093) }, { 0.000837d, new GammaParticle(1423300.0, 0.00087) }, { 0.0018135d, new GammaParticle(1442400.0, 0.00086) }, { 0.0017297999999999999d, new GammaParticle(1465600.0, 0.00085) }, { 0.0007532999999999999d, new GammaParticle(1516300.0, 0.00082) }, { 0.0004743d, new GammaParticle(1554500.0, 0.0008) }, { 0.0025109999999999998d, new GammaParticle(1709600.0, 0.00073) }, { 0.0007254d, new GammaParticle(1856300.0, 0.00067) }, { 0.0011997d, new GammaParticle(1913100.0, 0.00065) }, { 0.0060263999999999995d, new GammaParticle(2027200.0, 0.00061) }, { 0.0031806d, new GammaParticle(2156800.0, 0.00057) }, { 0.0018414d, new GammaParticle(2176000.0, 0.00057) }, { 0.0003348d, new GammaParticle(2311200.0, 0.00054) }, { 0.0014787000000000001d, new GammaParticle(2487100.0, 0.0005) }, { 0.0006138d, new GammaParticle(2615500.0, 0.00047) }, { 0.00039059999999999995d, new GammaParticle(2752600.0, 0.00045) }, { 0.0005859d, new GammaParticle(3181600.0, 0.00039) }, { 0.0012554999999999999d, new GammaParticle(3279900.0, 0.00038) }, { 0.001116d, new GammaParticle(3330800.0, 0.00037) }, { 0.0028458d, new GammaParticle(3441700.0, 0.00036) }, { 0.0008648999999999999d, new GammaParticle(3709500.0, 0.00033) }, { 0.0020367d, new GammaParticle(3902600.0, 0.00032) }, { 0.0022878d, new GammaParticle(4168800.0, 0.0003) }, { 0.0044361d, new GammaParticle(4463400.0, 0.00028) }, { 0.000558d, new GammaParticle(4772300.0, 0.00026) } } },

        };
    }
}
    