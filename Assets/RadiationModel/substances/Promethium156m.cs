using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium156m";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 155.93128d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.98d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Promethium156()), new(0.045570000000000006d, new GammaParticle(150300.0, 0.00825)), new(0.11164613544d, new GammaParticle(6109.0, 0.20295)), new(0.1669608626620783d, new GammaParticle(38171.0, 0.03248)), new(0.30312429677211017d, new GammaParticle(38724.0, 0.03202)), new(0.0939796344994523d, new GammaParticle(43934.0, 0.02822)), new(0.11813240056581155d, new GammaParticle(44387.0, 0.02793)), new(0.02415276606635924d, new GammaParticle(44938.0, 0.02759)) } },
            { 0.02d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium156()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.02d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Praseodymium152()), new(1.0d, new AlphaParticle(-1661497.9100000001)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    