using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum200 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum200";
        public override double halfLife { get; } = 45360.0d;
        public override double atomicWeight { get; } = 199.97144d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold200()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00133d, new GammaParticle(25210.0, 0.04918)), new(0.00037999999999999997d, new GammaParticle(27480.0, 0.04512)), new(0.0078000000000000005d, new GammaParticle(43670.0, 0.02839)), new(0.022400000000000003d, new GammaParticle(60000.0, 0.02066)), new(0.13d, new GammaParticle(76200.0, 0.01627)), new(0.00028000000000000003d, new GammaParticle(86400.0, 0.01435)), new(0.00122d, new GammaParticle(97520.0, 0.01271)), new(0.01d, new GammaParticle(103600.0, 0.01197)), new(0.032d, new GammaParticle(135940.0, 0.00912)), new(0.0022400000000000002d, new GammaParticle(137680.0, 0.00901)), new(0.0007000000000000001d, new GammaParticle(140090.0, 0.00885)), new(0.004699999999999999d, new GammaParticle(146540.0, 0.00846)), new(0.0024d, new GammaParticle(150610.0, 0.00823)), new(0.00061d, new GammaParticle(164950.0, 0.00752)), new(0.005d, new GammaParticle(166000.0, 0.00747)), new(0.0036d, new GammaParticle(167370.0, 0.00741)), new(0.00045d, new GammaParticle(179400.0, 0.00691)), new(0.00058d, new GammaParticle(183380.0, 0.00676)), new(0.00111d, new GammaParticle(189380.0, 0.00655)), new(0.006500000000000001d, new GammaParticle(200000.0, 0.0062)), new(0.00017d, new GammaParticle(212610.0, 0.00583)), new(0.00032d, new GammaParticle(218170.0, 0.00568)), new(0.0207d, new GammaParticle(227450.0, 0.00545)), new(0.0008799999999999999d, new GammaParticle(232800.0, 0.00533)), new(0.00077d, new GammaParticle(239560.0, 0.00518)), new(0.00053d, new GammaParticle(243710.0, 0.00509)), new(0.024d, new GammaParticle(243710.0, 0.00509)), new(0.00062d, new GammaParticle(251460.0, 0.00493)), new(0.00033d, new GammaParticle(286690.0, 0.00432)), new(0.0027d, new GammaParticle(292660.0, 0.00424)), new(0.00159d, new GammaParticle(303700.0, 0.00408)), new(0.00123d, new GammaParticle(313970.0, 0.00395)), new(0.0106d, new GammaParticle(330280.0, 0.00375)), new(0.0029d, new GammaParticle(390200.0, 0.00318)), new(0.000215d, new GammaParticle(408680.0, 0.00303)), new(0.0025d, new GammaParticle(468720.0, 0.00265)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    