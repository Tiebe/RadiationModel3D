using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium117m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium117m";
        public override double halfLife { get; } = 0.103d;
        public override double atomicWeight { get; } = 116.90896d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium117()), new(0.10310000000000001d, new GammaParticle(21600.0, 0.0574)), new(0.9508d, new GammaParticle(274400.0, 0.00452)), new(0.0888749456424d, new GammaParticle(4135.0, 0.29984)), new(0.01658795024113606d, new GammaParticle(27202.0, 0.04558)), new(0.0308900376929908d, new GammaParticle(27473.0, 0.04513)), new(0.00884019068683085d, new GammaParticle(31093.0, 0.03988)), new(0.010758512065873145d, new GammaParticle(31359.0, 0.03954)), new(0.0019183213790422945d, new GammaParticle(31698.0, 0.03911)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    