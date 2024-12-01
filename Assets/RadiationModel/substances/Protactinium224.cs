using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium224";
        public override double halfLife { get; } = 0.846d;
        public override double atomicWeight { get; } = 224.02562d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium220()), new(1.0d, new AlphaParticle(8715002.09)), new(0.0051d, new GammaParticle(28000.0, 0.04428)), new(0.003d, new GammaParticle(28000.0, 0.04428)), new(0.0134d, new GammaParticle(40700.0, 0.03046)), new(0.0026d, new GammaParticle(57800.0, 0.02145)), new(0.0038d, new GammaParticle(67800.0, 0.01829)), new(0.0027d, new GammaParticle(74000.0, 0.01675)), new(0.003d, new GammaParticle(81500.0, 0.01521)), new(0.003d, new GammaParticle(109500.0, 0.01132)), new(0.0051d, new GammaParticle(113100.0, 0.01096)), new(0.0016d, new GammaParticle(113300.0, 0.01094)), new(0.0048d, new GammaParticle(139200.0, 0.00891)), new(0.0017000000000000001d, new GammaParticle(151000.0, 0.00821)), new(0.010700000000000001d, new GammaParticle(153000.0, 0.0081)), new(0.0028000000000000004d, new GammaParticle(154700.0, 0.00801)), new(0.0084d, new GammaParticle(165100.0, 0.00751)), new(0.0019d, new GammaParticle(170500.0, 0.00727)), new(0.001d, new GammaParticle(182000.0, 0.00681)), new(0.0063d, new GammaParticle(184200.0, 0.00673)), new(0.015700000000000002d, new GammaParticle(194500.0, 0.00637)), new(0.0018d, new GammaParticle(247600.0, 0.00501)), new(0.0021d, new GammaParticle(287400.0, 0.00431)), new(0.0008d, new GammaParticle(294700.0, 0.00421)), new(0.0003d, new GammaParticle(298200.0, 0.00416)), new(0.0004d, new GammaParticle(315800.0, 0.00393)), new(0.0004d, new GammaParticle(335000.0, 0.0037)), new(0.0002d, new GammaParticle(398000.0, 0.00312)), new(0.0002d, new GammaParticle(412000.0, 0.00301)), new(0.71d, new GammaParticle(15349.0, 0.08078)), new(0.03592694968087446d, new GammaParticle(87674.0, 0.01414)), new(0.058398812875283576d, new GammaParticle(90886.0, 0.01364)), new(0.020591745614285065d, new GammaParticle(102818.0, 0.01206)), new(0.02744879690384199d, new GammaParticle(104107.0, 0.01191)), new(0.006857051289556926d, new GammaParticle(105738.0, 0.01173)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    