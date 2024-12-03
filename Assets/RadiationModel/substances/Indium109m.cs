using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium109m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium109m";
        public override double halfLife { get; } = 80.4d;
        public override double atomicWeight { get; } = 108.90785d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium109()), new(0.9351d, new GammaParticle(649800.0, 0.00191)), new(0.00409672224d, new GammaParticle(3571.0, 0.3472)), new(0.013217141644429118d, new GammaParticle(24001.0, 0.05166)), new(0.024797639107746936d, new GammaParticle(24209.0, 0.05121)), new(0.0069576632334655d, new GammaParticle(27367.0, 0.0453)), new(0.008279619247823946d, new GammaParticle(27581.0, 0.04495)), new(0.001321956014358445d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    