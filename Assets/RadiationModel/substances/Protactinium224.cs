using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium224";
        public override double halfLife { get; } = 0.846d;
        public override double atomicWeight { get; } = 224.02562d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium220() }, { 1.0d, new AlphaParticle(8715002.09) }, { 0.0051d, new GammaParticle(28000.0, 0.04428) }, { 0.003d, new GammaParticle(28000.0, 0.04428) }, { 0.0134d, new GammaParticle(40700.0, 0.03046) }, { 0.0026d, new GammaParticle(57800.0, 0.02145) }, { 0.0038d, new GammaParticle(67800.0, 0.01829) }, { 0.0027d, new GammaParticle(74000.0, 0.01675) }, { 0.003d, new GammaParticle(81500.0, 0.01521) }, { 0.003d, new GammaParticle(109500.0, 0.01132) }, { 0.0051d, new GammaParticle(113100.0, 0.01096) }, { 0.0016d, new GammaParticle(113300.0, 0.01094) }, { 0.0048d, new GammaParticle(139200.0, 0.00891) }, { 0.0017000000000000001d, new GammaParticle(151000.0, 0.00821) }, { 0.010700000000000001d, new GammaParticle(153000.0, 0.0081) }, { 0.0028000000000000004d, new GammaParticle(154700.0, 0.00801) }, { 0.0084d, new GammaParticle(165100.0, 0.00751) }, { 0.0019d, new GammaParticle(170500.0, 0.00727) }, { 0.001d, new GammaParticle(182000.0, 0.00681) }, { 0.0063d, new GammaParticle(184200.0, 0.00673) }, { 0.015700000000000002d, new GammaParticle(194500.0, 0.00637) }, { 0.0018d, new GammaParticle(247600.0, 0.00501) }, { 0.0021d, new GammaParticle(287400.0, 0.00431) }, { 0.0008d, new GammaParticle(294700.0, 0.00421) }, { 0.0003d, new GammaParticle(298200.0, 0.00416) }, { 0.0004d, new GammaParticle(315800.0, 0.00393) }, { 0.0004d, new GammaParticle(335000.0, 0.0037) }, { 0.0002d, new GammaParticle(398000.0, 0.00312) }, { 0.0002d, new GammaParticle(412000.0, 0.00301) }, { 0.71d, new GammaParticle(15349.0, 0.08078) }, { 0.03592694968087446d, new GammaParticle(87674.0, 0.01414) }, { 0.058398812875283576d, new GammaParticle(90886.0, 0.01364) }, { 0.020591745614285065d, new GammaParticle(102818.0, 0.01206) }, { 0.02744879690384199d, new GammaParticle(104107.0, 0.01191) }, { 0.006857051289556926d, new GammaParticle(105738.0, 0.01173) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    