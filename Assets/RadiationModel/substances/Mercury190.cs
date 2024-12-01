using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury190 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury190";
        public override double halfLife { get; } = 1200.0d;
        public override double atomicWeight { get; } = 189.96632d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum190()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00938d, new GammaParticle(28900.0, 0.0429)), new(0.00268d, new GammaParticle(48500.0, 0.02556)), new(0.00402d, new GammaParticle(100800.0, 0.0123)), new(0.00268d, new GammaParticle(122000.0, 0.01016)), new(0.00067d, new GammaParticle(125500.0, 0.00988)), new(0.01541d, new GammaParticle(129600.0, 0.00957)), new(0.00536d, new GammaParticle(129600.0, 0.00957)), new(0.00335d, new GammaParticle(133400.0, 0.00929)), new(0.0067d, new GammaParticle(135400.0, 0.00916)), new(0.00536d, new GammaParticle(137300.0, 0.00903)), new(0.67d, new GammaParticle(142600.0, 0.00869)), new(0.00335d, new GammaParticle(146500.0, 0.00846)), new(0.02479d, new GammaParticle(154700.0, 0.00801)), new(0.00067d, new GammaParticle(162500.0, 0.00763)), new(0.00938d, new GammaParticle(165400.0, 0.0075)), new(0.046900000000000004d, new GammaParticle(171500.0, 0.00723)), new(0.00268d, new GammaParticle(182300.0, 0.0068)), new(0.00603d, new GammaParticle(284800.0, 0.00435)), new(0.00603d, new GammaParticle(284800.0, 0.00435)), new(0.00268d, new GammaParticle(373800.0, 0.00332)), new(0.00201d, new GammaParticle(384500.0, 0.00322)), new(0.00603d, new GammaParticle(637900.0, 0.00194)), new(0.213801872039d, new GammaParticle(11419.0, 0.10858)), new(0.052706690343440464d, new GammaParticle(66991.0, 0.01851)), new(0.08972878846346692d, new GammaParticle(68806.0, 0.01802)), new(0.030277208062911266d, new GammaParticle(78048.0, 0.01589)), new(0.03902732119309262d, new GammaParticle(78983.0, 0.0157)), new(0.008750113130181356d, new GammaParticle(80133.0, 0.01547)) } },
            { 3.4e-09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum186()), new(1.0d, new AlphaParticle(5090002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    