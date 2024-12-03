using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium129m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium129m";
        public override double halfLife { get; } = 2903040.0d;
        public override double atomicWeight { get; } = 128.90671d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.64d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium129()), new(0.0014000000000000002d, new GammaParticle(105500.0, 0.01175)), new(0.046001798010000004d, new GammaParticle(4135.0, 0.29984)), new(0.07929347270294847d, new GammaParticle(27202.0, 0.04558)), new(0.14766009814329323d, new GammaParticle(27473.0, 0.04513)), new(0.042257747866687234d, new GammaParticle(31093.0, 0.03988)), new(0.051427679153758364d, new GammaParticle(31359.0, 0.03954)), new(0.00916993128707113d, new GammaParticle(31698.0, 0.03911)) } },
            { 0.36d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine129()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00027d, new GammaParticle(27810.0, 0.04458)), new(3.2000000000000003e-06d, new GammaParticle(76100.0, 0.01629)), new(2.7e-06d, new GammaParticle(115300.0, 0.01075)), new(2.8e-07d, new GammaParticle(208960.0, 0.00593)), new(6.6e-06d, new GammaParticle(242200.0, 0.00512)), new(3.9e-06d, new GammaParticle(250620.0, 0.00495)), new(5.8e-06d, new GammaParticle(278430.0, 0.00445)), new(9.399999999999999e-07d, new GammaParticle(281380.0, 0.00441)), new(5.1e-06d, new GammaParticle(281440.0, 0.00441)), new(6.1e-06d, new GammaParticle(320640.0, 0.00387)), new(1.4e-06d, new GammaParticle(357480.0, 0.00347)), new(1.1999999999999999e-05d, new GammaParticle(459600.0, 0.0027)), new(2.3e-06d, new GammaParticle(487390.0, 0.00254)), new(2.3e-06d, new GammaParticle(490340.0, 0.00253)), new(2.8e-06d, new GammaParticle(552430.0, 0.00224)), new(0.0011799999999999998d, new GammaParticle(556650.0, 0.00223)), new(4.7e-06d, new GammaParticle(562820.0, 0.0022)), new(0.00025d, new GammaParticle(671840.0, 0.00185)), new(0.03d, new GammaParticle(695880.0, 0.00178)), new(0.00025d, new GammaParticle(701700.0, 0.00177)), new(5.1000000000000006e-05d, new GammaParticle(705520.0, 0.00176)), new(2.3e-06d, new GammaParticle(716600.0, 0.00173)), new(0.006999999999999999d, new GammaParticle(729570.0, 0.0017)), new(0.00027d, new GammaParticle(740960.0, 0.00167)), new(2.8e-05d, new GammaParticle(768770.0, 0.00161)), new(2.9e-06d, new GammaParticle(771800.0, 0.00161)), new(5.6e-06d, new GammaParticle(794600.0, 0.00156)), new(0.00091d, new GammaParticle(817040.0, 0.00152)), new(0.00034d, new GammaParticle(844810.0, 0.00147)), new(6.1e-07d, new GammaParticle(924500.0, 0.00134)), new(7e-06d, new GammaParticle(1003650.0, 0.00124)), new(0.00017d, new GammaParticle(1022430.0, 0.00121)), new(0.00017999999999999998d, new GammaParticle(1050210.0, 0.00118)), new(9.000000000000001e-07d, new GammaParticle(1176000.0, 0.00105)), new(2.3e-06d, new GammaParticle(1203590.0, 0.00103)), new(4.2000000000000004e-06d, new GammaParticle(1254130.0, 0.00099)), new(2.2e-06d, new GammaParticle(1281960.0, 0.00097)), new(2.7e-06d, new GammaParticle(1373750.0, 0.0009)), new(3.5000000000000004e-05d, new GammaParticle(1401360.0, 0.00088)), new(0.00011363671946589999d, new GammaParticle(4335.0, 0.28601)), new(3.308465999717575e-05d, new GammaParticle(28318.0, 0.04378)), new(6.144996284765183e-05d, new GammaParticle(28613.0, 0.04333)), new(1.7704037035214036e-05d, new GammaParticle(32395.0, 0.03827)), new(2.170514940517241e-05d, new GammaParticle(32680.0, 0.03794)), new(4.001112369958372e-06d, new GammaParticle(33040.0, 0.03753)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    