using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium140";
        public override double halfLife { get; } = 15.8d;
        public override double atomicWeight { get; } = 139.93367d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium140() }, { 1.0d, new BetaParticle(1, 6837000.0) }, { 0.1188d, new GammaParticle(174800.0, 0.00709) }, { 0.011000000000000001d, new GammaParticle(185300.0, 0.00669) }, { 0.00418d, new GammaParticle(186700.0, 0.00664) }, { 0.053899999999999997d, new GammaParticle(191200.0, 0.00648) }, { 0.00979d, new GammaParticle(236700.0, 0.00524) }, { 0.00979d, new GammaParticle(253300.0, 0.00489) }, { 0.00836d, new GammaParticle(261800.0, 0.00474) }, { 0.00209d, new GammaParticle(269000.0, 0.00461) }, { 0.00099d, new GammaParticle(272400.0, 0.00455) }, { 0.01111d, new GammaParticle(278400.0, 0.00445) }, { 0.01397d, new GammaParticle(296600.0, 0.00418) }, { 0.0014299999999999998d, new GammaParticle(304500.0, 0.00407) }, { 0.0132d, new GammaParticle(313500.0, 0.00395) }, { 0.00209d, new GammaParticle(344500.0, 0.0036) }, { 0.00418d, new GammaParticle(372000.0, 0.00333) }, { 0.0594d, new GammaParticle(379000.0, 0.00327) }, { 0.0429d, new GammaParticle(417700.0, 0.00297) }, { 0.01254d, new GammaParticle(427900.0, 0.0029) }, { 0.0077d, new GammaParticle(436400.0, 0.00284) }, { 0.0069299999999999995d, new GammaParticle(446900.0, 0.00277) }, { 0.0209d, new GammaParticle(453400.0, 0.00273) }, { 0.01045d, new GammaParticle(495800.0, 0.0025) }, { 0.009899999999999999d, new GammaParticle(532000.0, 0.00233) }, { 0.022330000000000003d, new GammaParticle(546500.0, 0.00227) }, { 0.0363d, new GammaParticle(558700.0, 0.00222) }, { 0.0429d, new GammaParticle(575400.0, 0.00215) }, { 0.0066d, new GammaParticle(686200.0, 0.00181) }, { 0.01045d, new GammaParticle(708100.0, 0.00175) }, { 0.0297d, new GammaParticle(722300.0, 0.00172) }, { 0.11d, new GammaParticle(749900.0, 0.00165) }, { 0.0035199999999999997d, new GammaParticle(903200.0, 0.00137) }, { 0.009899999999999999d, new GammaParticle(918000.0, 0.00135) }, { 0.0143d, new GammaParticle(1041400.0, 0.00119) }, { 0.00561d, new GammaParticle(1131100.0, 0.0011) }, { 1.4709999999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.043944666819647996d, new GammaParticle(6603.0, 0.18777) }, { 0.06914162504370967d, new GammaParticle(40901.0, 0.03031) }, { 0.12475933786306329d, new GammaParticle(41541.0, 0.02985) }, { 0.03930424923785938d, new GammaParticle(47146.0, 0.0263) }, { 0.0494447455412271d, new GammaParticle(47645.0, 0.02602) }, { 0.01014049630336772d, new GammaParticle(48248.0, 0.0257) } } },

        };
    }
}
    