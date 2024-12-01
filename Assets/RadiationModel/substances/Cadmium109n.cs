using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium109n : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium109n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 108.90548d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium109()), new(0.9381d, new GammaParticle(203200.0, 0.0061)), new(0.8561d, new GammaParticle(259500.0, 0.00478)), new(0.012128144745872d, new GammaParticle(3388.0, 0.36595)), new(0.042357202392380694d, new GammaParticle(22983.0, 0.05395)), new(0.07966372464243124d, new GammaParticle(23173.0, 0.0535)), new(0.022205331138060953d, new GammaParticle(26184.0, 0.04735)), new(0.026246701405188047d, new GammaParticle(26381.0, 0.047)), new(0.004041370267127094d, new GammaParticle(26641.0, 0.04654)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    