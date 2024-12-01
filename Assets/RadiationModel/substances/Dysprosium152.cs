using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium152";
        public override double halfLife { get; } = 8568.0d;
        public override double atomicWeight { get; } = 151.92473d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9990000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium152()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.975d, new GammaParticle(256930.0, 0.00483)), new(0.158220800118d, new GammaParticle(7118.0, 0.17418)), new(0.21831357573317153d, new GammaParticle(43743.0, 0.02834)), new(0.39145342609498207d, new GammaParticle(44481.0, 0.02787)), new(0.12500465700702657d, new GammaParticle(50494.0, 0.02455)), new(0.15738086317184644d, new GammaParticle(51040.0, 0.02429)), new(0.032376206164819885d, new GammaParticle(51699.0, 0.02398)) } },
            { 0.001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium148()), new(1.0d, new AlphaParticle(4748402.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    