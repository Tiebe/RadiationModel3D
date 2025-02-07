using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium174";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 173.95312d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum174()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.19848500000000002d, new GammaParticle(112400.0, 0.01103)), new(0.365512d, new GammaParticle(243700.0, 0.00509)), new(0.047936d, new GammaParticle(349100.0, 0.00355)), new(0.012733000000000001d, new GammaParticle(533800.0, 0.00232)), new(0.046438d, new GammaParticle(739300.0, 0.00168)), new(0.01498d, new GammaParticle(759800.0, 0.00163)), new(0.026215000000000002d, new GammaParticle(777200.0, 0.0016)), new(0.017976000000000002d, new GammaParticle(863400.0, 0.00144)), new(0.02996d, new GammaParticle(900000.0, 0.00138)), new(0.037450000000000004d, new GammaParticle(903000.0, 0.00137)), new(0.012733000000000001d, new GammaParticle(981800.0, 0.00126)), new(0.056174999999999996d, new GammaParticle(1002900.0, 0.00124)), new(0.025466000000000003d, new GammaParticle(1088200.0, 0.00114)), new(0.121627903547115d, new GammaParticle(9740.0, 0.12729)), new(0.0489295347701375d, new GammaParticle(57983.0, 0.02138)), new(0.08499137531724422d, new GammaParticle(59320.0, 0.0209)), new(0.028171745607078726d, new GammaParticle(67335.0, 0.01841)), new(0.0358908039034183d, new GammaParticle(68117.0, 0.0182)), new(0.00771905829633957d, new GammaParticle(69068.0, 0.01795)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    