using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Berkelium248m : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium248m";
        public override double halfLife { get; } = 85320.0d;
        public override double atomicWeight { get; } = 248.07312d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.7d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium248()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.05d, new GammaParticle(550700.0, 0.00225)), new(0.000292606678d, new GammaParticle(19579.0, 0.06333)), new(0.00015767218484080396d, new GammaParticle(109867.0, 0.01128)), new(0.00024399904803590832d, new GammaParticle(115063.0, 0.01078)), new(9.301236513516789e-05d, new GammaParticle(129671.0, 0.00956)), new(0.00012612476712328766d, new GammaParticle(131332.0, 0.00944)), new(3.311240198811977e-05d, new GammaParticle(133529.0, 0.00929)) } },
            { 0.3d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium248()), new(6.6e-05d, new GammaParticle(43399.0, 0.02857)), new(0.14817675623999998d, new GammaParticle(18579.0, 0.06673)), new(0.0611966519265234d, new GammaParticle(104606.0, 0.01185)), new(0.09581439161816721d, new GammaParticle(109286.0, 0.01134)), new(0.035884920455110506d, new GammaParticle(123280.0, 0.01006)), new(0.0485164124553094d, new GammaParticle(124855.0, 0.00993)), new(0.012631492000198898d, new GammaParticle(126917.0, 0.00977)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    