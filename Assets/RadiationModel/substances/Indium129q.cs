using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium129q : RadioactiveSubstance
    {
        public override string name { get; } = "Indium129q";
        public override double halfLife { get; } = 0.11d;
        public override double atomicWeight { get; } = 128.9239d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium129()), new(0.855d, new GammaParticle(281000.0, 0.00441)), new(0.009042814339200001d, new GammaParticle(3571.0, 0.3472)), new(0.026984471106023856d, new GammaParticle(24001.0, 0.05166)), new(0.05062752552724926d, new GammaParticle(24209.0, 0.05121)), new(0.014204951988846123d, new GammaParticle(27367.0, 0.0453)), new(0.016903892866726885d, new GammaParticle(27581.0, 0.04495)), new(0.0026989408778807632d, new GammaParticle(27858.0, 0.04451)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    