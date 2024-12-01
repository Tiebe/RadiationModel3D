using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth200 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth200";
        public override double halfLife { get; } = 2184.0d;
        public override double atomicWeight { get; } = 199.97813d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium200()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.004d, new GammaParticle(83800.0, 0.0148)), new(0.003d, new GammaParticle(98090.0, 0.01264)), new(0.013000000000000001d, new GammaParticle(103250.0, 0.01201)), new(0.012d, new GammaParticle(114400.0, 0.01084)), new(0.009000000000000001d, new GammaParticle(201110.0, 0.00616)), new(0.457d, new GammaParticle(245150.0, 0.00506)), new(0.012d, new GammaParticle(273390.0, 0.00454)), new(0.009000000000000001d, new GammaParticle(294430.0, 0.00421)), new(0.022000000000000002d, new GammaParticle(303410.0, 0.00409)), new(0.032799999999999996d, new GammaParticle(319000.0, 0.00389)), new(0.005d, new GammaParticle(344600.0, 0.0036)), new(0.025d, new GammaParticle(348330.0, 0.00356)), new(0.004d, new GammaParticle(353600.0, 0.00351)), new(0.904d, new GammaParticle(419770.0, 0.00295)), new(0.9740000000000001d, new GammaParticle(462340.0, 0.00268)), new(0.023d, new GammaParticle(480430.0, 0.00258)), new(0.012d, new GammaParticle(494310.0, 0.00251)), new(0.005d, new GammaParticle(519200.0, 0.00239)), new(0.063d, new GammaParticle(536000.0, 0.00231)), new(0.017d, new GammaParticle(539140.0, 0.0023)), new(0.045d, new GammaParticle(545500.0, 0.00227)), new(0.008d, new GammaParticle(642700.0, 0.00193)), new(0.026000000000000002d, new GammaParticle(648000.0, 0.00191)), new(0.02d, new GammaParticle(781000.0, 0.00159)), new(0.01d, new GammaParticle(788600.0, 0.00157)), new(0.006999999999999999d, new GammaParticle(811000.0, 0.00153)), new(0.015d, new GammaParticle(836900.0, 0.00148)), new(0.01d, new GammaParticle(902600.0, 0.00137)), new(0.026000000000000002d, new GammaParticle(931700.0, 0.00133)), new(0.013999999999999999d, new GammaParticle(935300.0, 0.00133)), new(0.006999999999999999d, new GammaParticle(979800.0, 0.00127)), new(0.028999999999999998d, new GammaParticle(992900.0, 0.00125)), new(0.9940000000000001d, new GammaParticle(1026490.0, 0.00121)), new(0.011000000000000001d, new GammaParticle(1101400.0, 0.00113)), new(0.14073618986828001d, new GammaParticle(12522.0, 0.09901)), new(0.08488530640277844d, new GammaParticle(72805.0, 0.01703)), new(0.1426643805088713d, new GammaParticle(74970.0, 0.01654)), new(0.048760647195353515d, new GammaParticle(84986.0, 0.01459)), new(0.06348636264835028d, new GammaParticle(86022.0, 0.01441)), new(0.014725715452996764d, new GammaParticle(87301.0, 0.0142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    