using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc71 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc71";
        public override double halfLife { get; } = 145.2d;
        public override double atomicWeight { get; } = 70.92772d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium71() }, { 1.0d, new BetaParticle(-1, 1405150.0) }, { 0.029759999999999998d, new GammaParticle(121520.0, 0.0102) }, { 0.0384d, new GammaParticle(390000.0, 0.00318) }, { 0.0060799999999999995d, new GammaParticle(398600.0, 0.00311) }, { 0.00038399999999999996d, new GammaParticle(423200.0, 0.00293) }, { 0.0017599999999999998d, new GammaParticle(453100.0, 0.00274) }, { 0.0011840000000000002d, new GammaParticle(487300.0, 0.00254) }, { 0.32d, new GammaParticle(511600.0, 0.00242) }, { 0.0008d, new GammaParticle(520500.0, 0.00238) }, { 0.000288d, new GammaParticle(575100.0, 0.00216) }, { 0.008960000000000001d, new GammaParticle(666800.0, 0.00186) }, { 0.00544d, new GammaParticle(721400.0, 0.00172) }, { 0.0784d, new GammaParticle(910300.0, 0.00136) }, { 0.00768d, new GammaParticle(964800.0, 0.00129) }, { 0.0016320000000000002d, new GammaParticle(1109300.0, 0.00112) }, { 0.02176d, new GammaParticle(1120000.0, 0.00111) }, { 0.0008d, new GammaParticle(1144200.0, 0.00108) }, { 0.00032d, new GammaParticle(1241500.0, 0.001) }, { 8.96e-05d, new GammaParticle(1267000.0, 0.00098) }, { 0.00035200000000000005d, new GammaParticle(1383800.0, 0.0009) }, { 0.000256d, new GammaParticle(1553000.0, 0.0008) }, { 0.00384d, new GammaParticle(1631600.0, 0.00076) }, { 0.001696d, new GammaParticle(1904400.0, 0.00065) }, { 0.000448d, new GammaParticle(2064600.0, 0.0006) }, { 0.000256d, new GammaParticle(2294800.0, 0.00054) }, { 2.703718859302656e-05d, new GammaParticle(1127.0, 1.10013) }, { 0.0002409950825791467d, new GammaParticle(9225.0, 0.1344) }, { 0.0004683153567414433d, new GammaParticle(9252.0, 0.13401) }, { 0.00010273015010835981d, new GammaParticle(10306.0, 0.1203) }, { 0.00010334653100900997d, new GammaParticle(10313.0, 0.12022) }, { 6.163809006501589e-07d, new GammaParticle(10365.0, 0.11962) } } },

        };
    }
}
    